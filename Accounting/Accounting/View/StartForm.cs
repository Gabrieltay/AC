using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.Controller;
using Accounting.Model;
using Accounting.Util;

namespace Accounting.View
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            PopulateRecents();
        }

        private void PopulateRecents()
        {
            this.mRecentListview.Items.Clear();
            List<String> nRecents = RegistryController.GetRecents();
            foreach ( String nFilename in nRecents )
            {
                if ( File.Exists( nFilename ) )
                {
                    this.mRecentListview.Items.Add( nFilename );
                }
            }
        }

        private void mNewProfileButton_Click( object sender, EventArgs e )
        {
            ProfileForm form = new ProfileForm();
            form.ShowDialog( this );
            if ( form.DialogResult == DialogResult.OK )
            {
                Profile nProfile = form.Profile;
                ProfileController.getInstance().Init( nProfile );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void mOpenProfileButton_Click( object sender, EventArgs e )
        {
            try
            {
                DialogResult nResult = this.mOpenFileDialog.ShowDialog();
                if ( nResult == DialogResult.OK )
                {
                    Profile nProfile = Serializer.GetObjectFromFile<Profile>( this.mOpenFileDialog.FileName );
                    nProfile.Filename = this.mOpenFileDialog.FileName;
                    ProfileController.getInstance().Init( nProfile );
                    RegistryController.Add( this.mOpenFileDialog.FileName );
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
            catch ( IOException )
            {

            }
        }

        private void mRecentListview_ItemActivate( object sender, EventArgs e )
        {
            ListViewItem item = ( (ListView)sender ).FocusedItem;
            if ( File.Exists( item.Text ) )
            {
                Profile nProfile = Serializer.GetObjectFromFile<Profile>( item.Text );
                nProfile.Filename = item.Text;
                ProfileController.getInstance().Init( nProfile );
                RegistryController.Add( this.mOpenFileDialog.FileName );
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                RegistryController.Remove( item.Text );
                PopulateRecents();
            }

        }




    }
}
