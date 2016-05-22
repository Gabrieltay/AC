using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounting.View
{
    public partial class AboutForm : Form
    {
        private const String CHANGELOG_FILE = "CHANGELOG.txt";
        public AboutForm()
        {
            InitializeComponent();
            Initalize();
        }

        private void Initalize()
        {
            if ( File.Exists( CHANGELOG_FILE ) )
            {
                StreamReader nReader = new StreamReader( CHANGELOG_FILE );
                this.mChangeLogTxtbox.Text = nReader.ReadToEnd();
                nReader.Close();
            }
        }

        private void mChangeLogTxtbox_TextChanged( object sender, EventArgs e )
        {
            this.mChangeLogTxtbox.Focus();
            this.mChangeLogTxtbox.DeselectAll();
        }
    }
}
