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
    public partial class DisplayOLVForm : Form
    {
        public DisplayOLVForm(List<Record> aRecordList)
        {
            InitializeComponent();
            this.mTransactionOLV.Initialize();
            this.mTransactionOLV.AddObjects( aRecordList );

            decimal nCredit, nDebit, nBalance;
            ComputeBalance( aRecordList, out nBalance, out nCredit, out nDebit );
            this.mBalanceLabel.Text = "Balance : " + String.Format( "{0:C}", nBalance );
            this.mCreditLabel.Text = "Credit : " + String.Format( "{0:C}", nCredit );
            this.mDebitLabel.Text = "Debit : " + String.Format( "{0:C}", nDebit );
            this.mTotalLabel.Text = "Total Records : " + aRecordList.Count.ToString();
        }

        private decimal ComputeBalance(List<Record> aRecordList, out decimal nBalance, out decimal nCredit, out decimal nDebit)
        {
            nBalance = 0;
            nCredit = 0;
            nDebit = 0;
            foreach(Record nRecord in aRecordList)
            {
                if ( nRecord.Amount > 0 )
                    nDebit += nRecord.Amount;
                else
                    nCredit += nRecord.Amount;

                nBalance += nRecord.Amount;
            }
            return nBalance;
        }
    }
}
