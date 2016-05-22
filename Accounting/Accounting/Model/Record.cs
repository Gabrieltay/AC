using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Accounting.Model
{
    [Serializable]
    public class Record
    {
        public Record()
        {
            this.TransDate = DateTime.Today;
        }

        #region Column Properties

        [OLVColumn("TRANSACTION DATE", DisplayIndex=1, Width=135, AspectToStringFormat="{0:dd/MM/yy}", TextAlign=HorizontalAlignment.Left)]
        public DateTime TransDateCol
        {
            get
            {
                return this.TransDate;
            }
        }

        [OLVColumn("VOUCHER NO", DisplayIndex = 2, Width = 90, TextAlign = HorizontalAlignment.Center)]
        public String VoucherNoCol
        {
            get
            {
                return this.VoucherNo;
            }
        }

        [OLVColumn("G/L CODE", DisplayIndex = 3, Width = 70, TextAlign = HorizontalAlignment.Center)]
        public String GLCodeCol
        {
            get
            {
                return this.GLCode;
            }
        }

        [OLVColumn("CHEQUE NO", DisplayIndex = 4, Width = 80, TextAlign = HorizontalAlignment.Center)]
        public String ChequeNoCol
        {
            get
            {
                return this.ChequeNo;
            }
        }

        [OLVColumn( "ITEM CODE", DisplayIndex = 5, Width = 70, TextAlign = HorizontalAlignment.Center )]
        public String ItemCodeCol
        {
            get
            {
                return this.ItemCode;
            }
        }

        [OLVColumn("DESCRIPTION", DisplayIndex = 6, Width = 300, TextAlign = HorizontalAlignment.Left)]
        public String DescCol
        {
            get
            {
                return this.Description;
            }
        }

        [OLVColumn("AMT W/O GST", DisplayIndex = 7, Width = 90, TextAlign = HorizontalAlignment.Right)]
        public String AmtBefGstCol
        {
            get
            {
                if (this.AmtBefGst == 0)
                    return "";
                return String.Format( "{0:C}", this.AmtBefGst ).Replace( "$", "" );
            }
        }

        [OLVColumn("AMOUNT SGD(DR)", DisplayIndex = 8, Width = 120, TextAlign = HorizontalAlignment.Right)]
        public String AmtDrCol
        {
            get
            {
                if (this.Amount < 0)
                    return "";
                return String.Format( "{0:C}", this.Amount ).Replace( "$", "" );
            }
        }

        [OLVColumn("AMOUNT SGD(CR)", DisplayIndex = 9, Width = 120, TextAlign = HorizontalAlignment.Right)]
        public String AmtCrCol
        {
            get
            {
                if (this.Amount > 0)
                    return "";
                return String.Format( "{0:C}", this.Amount ).Replace( "$", "" );
            }
        }

        [OLVColumn("BALANCE SGD", DisplayIndex = 10, Width = 120, AspectToStringFormat = "{0:##,#.00;(##,#.00)}", TextAlign = HorizontalAlignment.Right)]
        public decimal BalanceCol
        {
            get
            {
                return this.Amount;
            }
        }

        #endregion


        #region Properties

        public DateTime TransDate
        {
            get;
            set;
        }

        public String Description
        {
            get;
            set;
        }

        public String VoucherNo
        {
            get;
            set;
        }

        public String GLCode
        {
            get;
            set;
        }

        public String ItemCode
        {
            get;
            set;
        }

        public String ChequeNo
        {
            get;
            set;
        }

        public decimal AmtBefGst
        {
            get;
            set;
        }

        public decimal Amount
        {
            get;
            set;
        }

        #endregion
    }
}
