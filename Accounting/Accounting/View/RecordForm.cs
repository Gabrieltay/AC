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
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
            this.CurRecord = new Record();
            InitializeFields(this.CurRecord);
        }

        public RecordForm(Record aRecord)
        {
            InitializeComponent();
            this.CurRecord = aRecord;
            InitializeFields(this.CurRecord);
        }

        private void InitializeFields(Record aRecord)
        {
            this.mDayTxtbox.Text = aRecord.TransDate.Day.ToString();
            this.mMthTxtbox.Text = aRecord.TransDate.Month.ToString();
            this.mYearTxtbox.Text = (aRecord.TransDate.Year - 2000).ToString();
            this.mVoucherTxtbox.Text = aRecord.VoucherNo;
            this.mGLCodeTxtbox.Text = aRecord.GLCode;
            this.mChequeTxtbox.Text = aRecord.ChequeNo;
            this.mItemCodeTxtbox.Text = aRecord.ItemCode;
            this.mDescTxtbox.Text = aRecord.Description;
            this.mAmtTxtbox.Text = aRecord.Amount.ToString("000.00");
            this.mRCodeDescLabel.Text = CodesController.getInstance().GetDescription( aRecord.GLCode );
        }

        private bool validateFields(out string aErrorMsg)
        {
            aErrorMsg = "";
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
            if (!DateTime.TryParse(nDateStr, nCulture, System.Globalization.DateTimeStyles.AssumeLocal, out date))
            {
                aErrorMsg = aErrorMsg + "Invalid Date - " + nDateStr + "\n";
                result = false;
            }
            else
            {
                this.CurRecord.TransDate = date;
            }

            decimal amount;
            if (!decimal.TryParse(nAmtStr, System.Globalization.NumberStyles.Currency, nCulture, out amount))
            {
                aErrorMsg = aErrorMsg + "Invalid Amount - " + nAmtStr + "\n";
                result = false;
            }
            else
            {
                this.CurRecord.Amount = amount;
            }

            this.CurRecord.VoucherNo = nVoucherStr;
            this.CurRecord.GLCode = nGLCodeStr;
            this.CurRecord.ChequeNo = nChequeStr;
            this.CurRecord.ItemCode = nItemCodeStr;
            this.CurRecord.Description = nDescStr;

            return result;
        }

        private void Submit()
        {
            string nErrorMsg;

            if (!validateFields(out nErrorMsg))
            {
                MessageBox.Show(this, nErrorMsg, "Error");
                this.DialogResult = DialogResult.Cancel;
            }
            this.DialogResult = DialogResult.OK;
        }

        #region Properties
        public Record CurRecord
        {
            get;
            set;
        }
        #endregion

        private void mOKButton_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void mAmtTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Submit();
        }

        private void mGLCodeTxtbox_KeyUp( object sender, KeyEventArgs e )
        {
            this.mRCodeDescLabel.Text = CodesController.getInstance().GetDescription( this.mGLCodeTxtbox.Text );
        }

    }
}
