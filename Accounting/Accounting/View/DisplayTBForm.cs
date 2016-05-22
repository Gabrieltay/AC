using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Accounting.Model;
using Accounting.Controller;

namespace Accounting.View
{
    public partial class DisplayTBForm : Form
    {
        public DisplayTBForm()
        {
            InitializeComponent();
        }

        public DisplayTBForm( List<Record> aRecordList )
        {
            InitializeComponent();
            this.mTrialBalanceOLV.Initialize();
            this.PopulateTrialBalance( aRecordList );
        }

        private void PopulateTrialBalance( List<Record> aRecordList )
        {

            Dictionary<GLCode, decimal> tbPair = new Dictionary<GLCode, decimal>();

            foreach ( Record nRecord in aRecordList )
            {
                GLCode nCode = CodesController.getInstance().ContainCode( nRecord.GLCode );

                if ( nCode == null )
                    continue;

                try
                {
                    tbPair[nCode] += nRecord.Amount;
                }
                catch ( KeyNotFoundException )
                {
                    tbPair.Add( nCode, nRecord.Amount );
                }
            }

            decimal nBalance = 0;
            decimal nCredit = 0;
            decimal nDebit = 0;

            foreach ( KeyValuePair<GLCode, decimal> nPair in tbPair )
            {
                TrialBalanceItem nItem = new TrialBalanceItem();
                nItem.Code = nPair.Key;
                nItem.Balance = nPair.Value;
                this.mTrialBalanceOLV.AddObject( nItem );

                if ( nItem.Balance > 0 )
                    nDebit += nItem.Balance;
                else
                    nCredit += nItem.Balance;

                nBalance += nItem.Balance;
            }
            
            this.mBalanceLabel.Text = "Balance : " + String.Format( "{0:C}", nBalance );
            this.mCreditLabel.Text = "Credit : " + String.Format( "{0:C}", nCredit );
            this.mDebitLabel.Text = "Debit : " + String.Format( "{0:C}", nDebit );
            this.mTotalLabel.Text = "Total Records : " + tbPair.Count.ToString();

        }
    }
}
