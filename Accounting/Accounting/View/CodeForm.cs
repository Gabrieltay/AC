using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.Controller;
using Accounting.Model;
using Accounting.Observers;
using System.Collections;

namespace Accounting.View
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }

        public CodeForm( DataModel<GLCode> aDataModel )
        {
            InitializeComponent();
            this.DataModel = aDataModel;

            this.Observer = new OLVObserver( this.mCodeOLV );
            this.FormObserver = new CodeFormObserver( this );

            this.DataModel.Subscribe( this.Observer );
            this.DataModel.Subscribe( this.FormObserver );

            this.mCodeOLV.Initialize();
            this.mCodeOLV.AddObjects( this.DataModel.GetList() );

            this.ClearForm();
        }

        private void AddCode()
        {
            if ( String.IsNullOrEmpty( mCCodeTxtbox.Text ) || String.IsNullOrEmpty( mCDescTxtbox.Text ) )
            {
                MessageBox.Show( "Fields cannot be emptied." );
                return;
            }

            GLCode.GLType nType = GLCode.GLType.IE;

            if ( mCIncomeRbutton.Checked )
                nType = GLCode.GLType.IE;
            else if ( mCBalRButton.Checked )
                nType = GLCode.GLType.BAL;

            GLCode nNewCode = new GLCode( mCCodeTxtbox.Text, mCDescTxtbox.Text, nType );

            CodesController.getInstance().AddCode( nNewCode );
        }

        private void EditCode()
        {
            if ( String.IsNullOrEmpty( mCCodeTxtbox.Text ) || String.IsNullOrEmpty( mCDescTxtbox.Text ) )
            {
                MessageBox.Show( "Fields cannot be emptied." );
                this.ClearForm();
                return;
            }

            DialogResult nResult =  MessageBox.Show( "Confirm Overwrite?", "Edit Confirmation", MessageBoxButtons.YesNo );
            if ( nResult == DialogResult.Yes )
            {
                if ( mCIncomeRbutton.Checked )
                    this.CurCode.Type = GLCode.GLType.IE;
                else if ( mCBalRButton.Checked )
                    this.CurCode.Type = GLCode.GLType.BAL;
                this.CurCode.Code = mCCodeTxtbox.Text;
                this.CurCode.Desc = mCDescTxtbox.Text;

                CodesController.getInstance().EditCode( this.CurCode );
            }

        }

        public void ClearForm()
        {
            this.CurCode = null;
            this.mCCodeTxtbox.Text = "";
            this.mCDescTxtbox.Text = "";
            this.mCIncomeRbutton.Checked = true;
            this.mCCodeTxtbox.Focus();
            this.mCAddBButton.Text = "Add";
        }

        #region Properties
        private DataModel<GLCode> DataModel
        {
            get;
            set;
        }

        private OLVObserver Observer
        {
            get;
            set;
        }

        private CodeFormObserver FormObserver
        {
            get;
            set;
        }

        private GLCode CurCode
        {
            get;
            set;
        }
        #endregion

        #region Tool Strip Handlers
        private void mCImportButton_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.mOpenFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                CodesController.getInstance().ImportCSV( this.mOpenFileDialog.FileName );
            }
        }

        private void mCExportButton_Click( object sender, EventArgs e )
        {
            DialogResult nResult = this.mSaveFileDialog.ShowDialog();
            if ( nResult == DialogResult.OK )
            {
                CodesController.getInstance().ExportCSV(this.mSaveFileDialog.FileName);
            }
        }
        #endregion

        #region Context Menu Handlers
        private void deleteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CodesController.getInstance().DeleteCodes( (ArrayList)this.mCodeOLV.SelectedObjects );
        }
        #endregion

        #region OLV Handlers
        private void mCodeOLV_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Delete )
            {
                CodesController.getInstance().DeleteCodes( (ArrayList)this.mCodeOLV.SelectedObjects );
            }
        }

        private void mCodeOLV_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( this.mCodeOLV.SelectedItems.Count == 1 )
            {
                GLCode nCurCode = (GLCode)this.mCodeOLV.SelectedObject;
                this.mCCodeTxtbox.Text = nCurCode.Code;
                this.mCDescTxtbox.Text = nCurCode.Desc;
                if ( nCurCode.Type == GLCode.GLType.IE )
                    this.mCIncomeRbutton.Checked = true;
                if ( nCurCode.Type == GLCode.GLType.BAL )
                    this.mCBalRButton.Checked = true;
                this.mCAddBButton.Text = "Edit";
                this.CurCode = nCurCode;
            }
        }

        #endregion

        private void mCDescTxtbox_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == '\r' )
                AddCode();
        }

        private void mCAddBButton_Click( object sender, EventArgs e )
        {
            if ( this.CurCode == null )
                AddCode();
            else
                EditCode();
        }

        private void mCClearButton_Click( object sender, EventArgs e )
        {
            ClearForm();
        }
    }
}
