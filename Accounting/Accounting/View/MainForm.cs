using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using Accounting.Model;
using Accounting.Util;
using Accounting.Controller;
using Accounting.Observers;
using BrightIdeasSoftware;
using System.Collections;

namespace Accounting.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeProfile();
            InitializeComponent();
            InitializeOLV();
            LoadProfile();
        }

        private void InitializeProfile()
        {
            StartForm form = new StartForm();
            form.ShowDialog( this );
            if ( form.DialogResult == DialogResult.OK )
            {
                this.Profile = ProfileController.getInstance().Profile;
            }
            else if ( form.DialogResult == DialogResult.Cancel )
            {
                throw new ApplicationException();
            }
        }

        private void InitializeOLV()
        {
            this.CodeModel = new DataModel<GLCode>();
            this.RecordModel = new DataModel<Record>();

            this.mTransactionOLV.Initialize();

            OLVObserver nTransactionObserver = new OLVObserver( this.mTransactionOLV );
            MainFormObserver nMainObserver = new MainFormObserver( this );

            this.RecordModel.Subscribe( nTransactionObserver );
            this.RecordModel.Subscribe( nMainObserver );

            TransactionsController.getInstance().Init( this.RecordModel );
            CodesController.getInstance().Init( this.CodeModel );
        }

        private void NewProfile()
        {
            ProfileForm form = new ProfileForm();
            DialogResult nResult = form.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                ProfileController.getInstance().Init( form.Profile );
                this.Profile = form.Profile;
                LoadProfile();
            }
        }

        private void LoadProfile()
        {
            this.Text = this.Profile.Client.Name;
            this.CodeModel.Clear();
            this.CodeModel.Add( this.Profile.CodeList, true );
            this.RecordModel.Clear();
            this.RecordModel.Add( this.Profile.CurDataList, true );
            this.mTransactionOLV.Sort();
        }

        private bool SaveFile( bool aSaveAs = false )
        {
            try
            {
                if ( this.mTransactionOLV.Items.Count <= 0 )
                {
                    MessageBox.Show( "Nothing to save!" );
                    return false;
                }

                if ( String.IsNullOrEmpty( this.Profile.Filename ) || aSaveAs )
                {
                    DialogResult nResult = this.mSaveFileDialog.ShowDialog();
                    if ( nResult == DialogResult.OK )
                    {
                        this.Profile.Filename = this.mSaveFileDialog.FileName;
                    }
                    else
                    {
                        return false;
                    }
                }

                ProfileController.getInstance().SaveRecords( this.RecordModel );
                ProfileController.getInstance().SaveCodes( this.CodeModel );
                ProfileController.getInstance().Save( this.Profile.Filename );
                RegistryController.Add( this.Profile.Filename );
                this.mStatusLabel.Text = "Saved";

                return true;
            }
            catch ( IOException )
            {
                return false;
            }
        }

        private bool OpenFile( String aFilename = "" )
        {
            try
            {
                if ( String.IsNullOrEmpty( aFilename ) )
                {
                    DialogResult nResult = this.mOpenFileDialog.ShowDialog();
                    if ( nResult == DialogResult.OK )
                    {
                        ProfileController.getInstance().Open( this.mOpenFileDialog.FileName );
                        this.Profile = ProfileController.getInstance().Profile;
                        this.Profile.Filename = this.mOpenFileDialog.FileName;
                        this.LoadProfile();
                        return true;
                    }
                }
                else
                {
                    if ( File.Exists( aFilename ) )
                    {
                        ProfileController.getInstance().Open( aFilename );
                        this.Profile = ProfileController.getInstance().Profile;
                        this.Profile.Filename = aFilename;
                        this.LoadProfile();
                        return true;
                    }
                }
                return false;
            }
            catch ( IOException )
            {
                return false;
            }
        }

        #region Properties

        private Profile Profile
        {
            get;
            set;
        }

        private Accounting.Model.DataModel<Record> RecordModel
        {
            get;
            set;
        }

        private Accounting.Model.DataModel<GLCode> CodeModel
        {
            get;
            set;
        }

        #endregion

        #region Delegates
        delegate void UpdateStatusDelegate( String aStatus );

        private void UpdateStatusSafe( String aStatus )
        {
            this.mStatusLabel.Text = aStatus;
        }

        public void UpdateStatus( String aStatus )
        {
            UpdateStatusDelegate updateStatusDelegate = new UpdateStatusDelegate( UpdateStatusSafe );
            this.Invoke( updateStatusDelegate, new object[] { aStatus } );
        }

        delegate void UpdateBalanceDelegate( String aBalance );

        private void UpdateBalanceSafe( String aBalance )
        {
            this.mBalancesLabel.Text = "Balance : " + aBalance;
        }

        public void UpdateBalance( String aBalance )
        {
            UpdateBalanceDelegate updateBalanceDelegate = new UpdateBalanceDelegate( UpdateBalanceSafe );
            this.Invoke( updateBalanceDelegate, new object[] { aBalance } );
        }

        delegate void UpdateCountDelegate( int aCount );

        private void UpdateCountSafe( int aCount )
        {
            this.mTotalRecordsLabel.Text = "Total Records : " + aCount.ToString();
        }

        public void UpdateCount( int aCount )
        {
            UpdateCountDelegate updateCountDelegate = new UpdateCountDelegate( UpdateCountSafe );
            this.Invoke( updateCountDelegate, new object[] { aCount } );
        }

        #endregion

        private void CentraliseKeyControls( object sender, KeyEventArgs e )
        {
            if ( e.Control && e.KeyCode == Keys.S )
                SaveFile();
            else if ( e.Control && e.KeyCode == Keys.O )
                OpenFile();
            else if ( e.Control && e.KeyCode == Keys.R )
                TransactionsController.getInstance().AddRecord();
            else if ( e.KeyCode == Keys.Delete )
                TransactionsController.getInstance().DeleteRecords( (ArrayList)this.mTransactionOLV.SelectedObjects );
        }

        #region Main Form Event Handlers
        private void mainForm_KeyDown( object sender, KeyEventArgs e )
        {
            CentraliseKeyControls( sender, e );
        }

        private void mFilterTxtbox_TextChanged( object sender, EventArgs e )
        {
            // All OLV shall perform filtering 
            this.mTransactionOLV.TimeFilter( mFilterTxtbox.Text );
        }

        #endregion

        #region Menu Strip Handlers
        private void mProfileMenuItem_Click( object sender, EventArgs e )
        {
            NewProfile();
        }

        private void mOpenMenuItem_Click( object sender, EventArgs e )
        {
            OpenFile();
        }

        private void mSaveMenuItem_Click( object sender, EventArgs e )
        {
            SaveFile();
        }

        private void mSaveAsMenuItem_Click( object sender, EventArgs e )
        {
            SaveFile( aSaveAs: true );
        }

        private void mImportCSVMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.mOpenCSVFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                TransactionsController.getInstance().ImportCV( this.mOpenCSVFileDialog.FileName );
            }
        }

        private void mExportCSVMenuItem_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.mSaveCSVFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                TransactionsController.getInstance().ExportCSV( this.mSaveCSVFileDialog.FileName );
            }
        }

        private void mExitMenuItem_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }

        #endregion

        #region Tool Strip Handlers
        private void mNewButton_Click( object sender, EventArgs e )
        {
            NewProfile();
        }

        private void mSaveButton_Click( object sender, EventArgs e )
        {
            SaveFile();
        }

        private void mOpenButton_Click( object sender, EventArgs e )
        {
            OpenFile();
        }

        private void mCodeButton_Click( object sender, EventArgs e )
        {
            CodeForm form = new CodeForm( this.CodeModel );
            form.ShowDialog( this );
            form.Dispose();
        }

        private void Filter_Click( object sender, EventArgs e )
        {
            FilterForm form = new FilterForm();
            form.ShowDialog();
        }

        private void mAddButton_Click( object sender, EventArgs e )
        {
            TransactionsController.getInstance().AddRecord();
        }

        private void mTransactionsButton_Click( object sender, EventArgs e )
        {
            TransactionsForm nTransactionsForm = new TransactionsForm();
            nTransactionsForm.ShowDialog( this );
            if ( nTransactionsForm.DialogResult == DialogResult.OK )
            {
                TransactionsController.getInstance().AddRecords( nTransactionsForm.GetRecords() );
            }
            nTransactionsForm.Dispose();
        }
        private void mAboutButton_Click( object sender, EventArgs e )
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }
        #endregion

        #region Context Menu Handlers
        private void addToolStripMenuItem_Click( object sender, EventArgs e )
        {
            TransactionsController.getInstance().AddRecord();
        }

        private void editToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if ( this.mTransactionOLV.SelectedItems.Count == 1 )
            {
                TransactionsController.getInstance().EditRecord( (Record)this.mTransactionOLV.SelectedObject );
            }
        }

        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            TransactionsController.getInstance().DeleteRecords( (ArrayList)this.mTransactionOLV.SelectedObjects );
        }
        #endregion

        #region Transaction OLV Event Handlers
        private void mTransactionOLV_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( this.mTransactionOLV.SelectedItems.Count == 1 )
            {
                TransactionsController.getInstance().EditRecord( (Record)this.mTransactionOLV.SelectedObject );
            }
        }

        private void mTransactionOLV_KeyDown( object sender, KeyEventArgs e )
        {
            CentraliseKeyControls( sender, e );
        }

        private void mTransactionOLV_DragDrop( object sender, DragEventArgs e )
        {
            object obj = e.Data.GetData( DataFormats.FileDrop );
            Array files = obj as Array;
            if ( files.Length != 1 )
                return;

            string filename = (string)files.GetValue( 0 );
            if ( Directory.Exists( filename ) )
            {
                return;
            }
            this.OpenFile( filename );
        }

        private void mTransactionOLV_DragEnter( object sender, DragEventArgs e )
        {
            e.Effect = DragDropEffects.Copy;
        }
        #endregion


        private void toolStripButton1_Click( object sender, EventArgs e )
        {
            MessageBox.Show( "Record Count - " + this.Profile.CurDataList.Count.ToString() + ", Code Count - " + this.Profile.CodeList.Count.ToString() );

        }
    }
}
