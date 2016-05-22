using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;


namespace Accounting.Model
{
    public class TrialBalanceItem
    {
        [OLVColumn( "G/L CODE", DisplayIndex = 1, Width = 70, TextAlign = HorizontalAlignment.Center )]
        public String CodeCol
        {
            get
            {
                return this.Code.Code;
            }
        }

        [OLVColumn( "DESCRIPTION", DisplayIndex = 2, Width = 200, TextAlign = HorizontalAlignment.Center )]
        public String DescCol
        {
            get
            {
                return this.Code.Desc;
            }
        }

        [OLVColumn( "AMOUNT SGD(DR)", DisplayIndex = 3, Width = 120, TextAlign = HorizontalAlignment.Right )]
        public String AmtDrCol
        {
            get
            {
                if ( this.Balance < 0 )
                    return "";
                return String.Format( "{0:C}", this.Balance ).Replace( "$", "" );
            }
        }

        [OLVColumn( "AMOUNT SGD(CR)", DisplayIndex = 4, Width = 120, TextAlign = HorizontalAlignment.Right )]
        public String AmtCrCol
        {
            get
            {
                if ( this.Balance > 0 )
                    return "";
                return String.Format( "{0:C}", this.Balance ).Replace( "$", "" );
            }
        }

        [OLVColumn( "BALANCE SGD", DisplayIndex = 5, Width = 120, AspectToStringFormat = "{0:##,#.00;(##,#.00)}", TextAlign = HorizontalAlignment.Right )]
        public decimal AmtCol
        {
            get
            {
                return this.Balance;
            }
        }

        #region Properties
        public GLCode Code
        {
            get; set;
        }

        public decimal Balance
        {
            get; set;
        }
        #endregion
    }
}
