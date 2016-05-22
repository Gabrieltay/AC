using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.Model;

namespace Accounting.View
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private bool validateFields()
        {
            if ( String.IsNullOrEmpty( this.mCoyNameTxtbox.Text ) )
                return false;

            return true;
        }

        #region Properties
        public Profile Profile
        {
            get;
            set;
        }
        #endregion

        private void ProfileForm_FormClosed( object sender, FormClosedEventArgs e )
        {
            if ( validateFields() )
            {
                this.Profile = new Profile();
                this.Profile.Client = new Company( this.mCoyNameTxtbox.Text );
            }
        }
    }
}
