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
using System.Collections;

namespace Accounting.View
{
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
            this.mOLV.Initialize();
        }

        public IEnumerable GetRecords()
        {
            return this.mOLV.Objects;
        }
        
        private void AddRecord()
        {
            Record nRecord;
            if ( validateFields( out nRecord ) )
            {
                this.mOLV.AddObject( nRecord );

                if ( this.mAutoRButton.Checked )
                {
                    Record nRecord2;
                    if ( validateFields( out nRecord2 ) )
                    {
                        nRecord2.Amount *= -1;
                        this.mOLV.AddObject( nRecord2 );
                    }
                }
                computeBalance();
                this.mGLCodeTxtbox.Focus();
            }
        }

        private void DeleteRecord()
        {
            if ( this.mOLV.SelectedItems.Count > 0 )
            {
                this.mOLV.RemoveObjects( this.mOLV.SelectedObjects );
                computeBalance();
            }
        }

        private void computeBalance()
        {
            decimal nBalance = 0;

            foreach ( object nObj in this.mOLV.Objects )
            {
                nBalance += ( (Record)nObj ).Amount;
            }
 
            this.mBalTxtbox.Text = String.Format("{0:C}", nBalance ).Replace("$","");
        }

        private bool validateFields(out Record aRecord)
        {
            aRecord = new Record();

            string aErrorMsg = "";
            bool result = true;

            IFormatProvider nCulture = System.Globalization.CultureInfo.CurrentCulture;

            string nDateStr = this.mDayTxtbox.Text + "/" + this.mMthTxtbox.Text + "/20" + this.mYearTxtbox.Text;
            string nVoucherStr = this.mVoucherTxtbox.Text;
            string nGLCodeStr = this.mGLCodeTxtbox.Text;
            string nChequeStr = this.mChequeTxtbox.Text;
            string nItemCodeStr = this.mItemCodeTxtbox.Text;
            string nDescStr = this.mDescTxtbox.Text;
            string nAmtStr = this.mAmtTxtbox.Text;

            DateTime date;
            if ( !DateTime.TryParse( nDateStr, nCulture, System.Globalization.DateTimeStyles.AssumeLocal, out date ) )
            {
                aErrorMsg = aErrorMsg + "Invalid Date - " + nDateStr + "\n";
                result = false;
            }
            else
            {
                aRecord.TransDate = date;
            }

            decimal amount;
            if ( !decimal.TryParse( nAmtStr, System.Globalization.NumberStyles.Currency, nCulture, out amount ) )
            {
                aErrorMsg = aErrorMsg + "Invalid Amount - " + nAmtStr + "\n";
                result = false;
            }
            else
            {
                aRecord.Amount = amount;
            }

            aRecord.VoucherNo = nVoucherStr;
            aRecord.GLCode = nGLCodeStr;
            aRecord.ChequeNo = nChequeStr;
            aRecord.ItemCode = nItemCodeStr;
            aRecord.Description = nDescStr;

            return result;
        }


        #region Properties

        #endregion

        private void mAmtTxtbox_KeyPress( object sender, KeyPressEventArgs e )
        {
            if ( e.KeyChar == '\r' )
                AddRecord();
        }

        private void mGLCodeTxtbox_TextChanged( object sender, EventArgs e )
        {
            this.mRCodeDescLabel.Text = CodesController.getInstance().GetDescription( this.mGLCodeTxtbox.Text );
        }

        private void mOLV_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Delete )
                DeleteRecord();
        }
    }
}
