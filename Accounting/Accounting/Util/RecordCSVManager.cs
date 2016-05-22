using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Base;
using Accounting.Model;
using System.Globalization;

namespace Accounting.Util
{
    public class RecordCSVManager : BaseCSVManager<Record>
    {
        public RecordCSVManager()
        {
        }

        protected override Record ParseCSV( string[] aStrArray )
        {
            if ( aStrArray.Length < 9 )
                return null;

            Record nRecord = new Record();

            IFormatProvider nCulture = System.Globalization.CultureInfo.CurrentCulture;
            DateTime nParseDateStr;

            // Transaction Date
            if ( DateTime.TryParse( aStrArray[0], nCulture, System.Globalization.DateTimeStyles.AssumeLocal, out nParseDateStr ) )
                nRecord.TransDate = nParseDateStr;
            else
                nRecord.TransDate = new DateTime( 1970, 1, 1 );

            // Voucher No
            nRecord.VoucherNo = aStrArray[1];

            // GL Code
            nRecord.GLCode = aStrArray[2];

            // Cheque No
            nRecord.ChequeNo = aStrArray[3];

            // Item Code
            nRecord.ItemCode = aStrArray[4];

            // Description
            nRecord.Description = aStrArray[5];

            // Amt Before Gst
            if ( aStrArray[6].Contains( '"' ) )
                aStrArray[6] = aStrArray[6].Replace( "\"", "" );
            if ( !String.IsNullOrEmpty( aStrArray[6] ) )
                nRecord.AmtBefGst = decimal.Parse( aStrArray[6], NumberStyles.Currency );

            // Amount
            if ( aStrArray[9].Contains( '"' ) )
                aStrArray[9] = aStrArray[9].Replace( "\"", "" );
            if ( !String.IsNullOrEmpty( aStrArray[9] ) )
                nRecord.Amount = decimal.Parse( aStrArray[9], NumberStyles.Currency );

            return nRecord;
        }

        protected override string WriteCSV( Record aObj )
        {
            String nCsvStr = "";
            nCsvStr += aObj.TransDateCol.ToShortDateString() + ",";
            nCsvStr += aObj.VoucherNoCol + ",";
            nCsvStr += aObj.GLCodeCol + ",";
            nCsvStr += aObj.ChequeNoCol + ",";
            nCsvStr += aObj.ItemCode + ",";
            nCsvStr += aObj.DescCol + ",";
            nCsvStr += "\"" + aObj.AmtBefGstCol + "\"" + ",";
            nCsvStr += "\"" + aObj.AmtDrCol + "\"" + ",";
            nCsvStr += "\"" + aObj.AmtCrCol + "\"" + ",";
            nCsvStr += "\"" + aObj.BalanceCol + "\"" + ",";

            return nCsvStr;
        }
    }
}
