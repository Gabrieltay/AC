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

namespace Accounting.View
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
            this.mCodeOLV.Initialize();
            Initialize();
        }

        private void Initialize()
        {
            this.mFilterListbox.SelectedIndex = 0;

            DateTime curDate = DateTime.Today;
            for ( int i = curDate.Year - 5 ; i < curDate.Year + 5 ; i++ )
                this.mYearComboBox.Items.Add( i.ToString() );
            this.mMonthComboBox.Text = this.mMonthComboBox.Items[curDate.Month - 1].ToString();
            this.mYearComboBox.Text = curDate.Year.ToString();

            this.mFromDatePicker.Value = curDate.AddMonths( -1 );
            this.mToDatePicker.Value = curDate;

            this.mCodeOLV.AddObjects( CodesController.getInstance().GetList() );
            this.mCodeOLV.CheckAll();
        }

        private void DateRadioChanged()
        {
            if ( mAllRButton.Checked )
            {
                this.mMonthComboBox.Enabled = false;
                this.mYearComboBox.Enabled = false;
                this.mToLabel.Enabled = false;
                this.mFromDatePicker.Enabled = false;
                this.mToDatePicker.Enabled = false;
            }
            else if ( mMonthRButton.Checked )
            {
                this.mMonthComboBox.Enabled = true;
                this.mYearComboBox.Enabled = true;
                this.mToLabel.Enabled = false;
                this.mFromDatePicker.Enabled = false;
                this.mToDatePicker.Enabled = false;
            }
            else
            {
                this.mMonthComboBox.Enabled = false;
                this.mYearComboBox.Enabled = false;
                this.mToLabel.Enabled = true;
                this.mFromDatePicker.Enabled = true;
                this.mToDatePicker.Enabled = true;
            }
        }

        private void mRangeRButton_CheckedChanged( object sender, EventArgs e )
        {
            DateRadioChanged();
        }

        private void mMonthRButton_CheckedChanged( object sender, EventArgs e )
        {
            DateRadioChanged();
        }

        private void mAllRButton_CheckedChanged( object sender, EventArgs e )
        {
            DateRadioChanged();
        }

        private void mFilterButton_Click( object sender, EventArgs e )
        {
            List<Record> nFilterList = null;    

            if ( this.mAllRButton.Checked )
            {
                nFilterList =  TransactionsController.getInstance().Filter(FilterCodes: this.mCodeOLV.CheckedObjects );
            }
            if ( this.mMonthRButton.Checked )
            {
                int nYear = int.Parse( this.mYearComboBox.Text );
                int nMonth = this.mMonthComboBox.SelectedIndex + 1;
                DateTime startDate = new DateTime( nYear, nMonth, 1 );
                DateTime endDate = new DateTime( nYear, nMonth, DateTime.DaysInMonth( nYear, nMonth ) );
                nFilterList = TransactionsController.getInstance().Filter( startDate, endDate, this.mCodeOLV.CheckedObjects ) ;
            }
            if ( this.mRangeRButton.Checked)
            {
                DateTime startDate = this.mFromDatePicker.Value;
                DateTime endDate = this.mToDatePicker.Value;
                nFilterList = TransactionsController.getInstance().Filter( startDate, endDate, this.mCodeOLV.CheckedObjects );
            }

            if ( ((String)(this.mFilterListbox.Text)).Equals( "Transactions") ) 
            {
                DisplayOLVForm form = new DisplayOLVForm( nFilterList );
                form.Show();
            }
            else if ( ( (String)( this.mFilterListbox.Text ) ).Equals( "Trial Balance" ) )
            {
                DisplayTBForm form = new DisplayTBForm( nFilterList );
                form.Show();
            }
        }

        private void mAllButton_Click( object sender, EventArgs e )
        {
            this.mCodeOLV.CheckAll();
        }

        private void mClearButton_Click( object sender, EventArgs e )
        {
            this.mCodeOLV.UncheckAll();
        }
    }
}
