using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Base;
using Accounting.Model;
using System.Globalization;

namespace Accounting.Util
{
    public class CodeCSVManager : BaseCSVManager<GLCode>
    {
        public CodeCSVManager()
        {
        }

        protected override GLCode ParseCSV( string[] aStrArray )
        {
            if ( aStrArray.Length < 3 )
                return null;

            GLCode nCode = new GLCode();

            nCode.Code = aStrArray[0];
            nCode.Desc = aStrArray[1];
            if ( aStrArray[2].Equals( GLCode.GLType.IE.ToString() ) )
                nCode.Type = GLCode.GLType.IE;
            else
                nCode.Type = GLCode.GLType.BAL;

            return nCode;
        }

        protected override string WriteCSV( GLCode aObj )
        {
            String nCsvStr = "";
            nCsvStr += aObj.Code + ",";
            nCsvStr += aObj.Desc + ",";
            nCsvStr += aObj.Type.ToString();
            return nCsvStr;
        }
    }
}
