using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace Accounting.Model
{
    [Serializable]
    public class GLCode
    {
        public enum GLType
        {
            IE = 0,  // Income/Expenditure 
            BAL       // Balance Sheet
        }

        public GLCode()
        {
        }

        #region Properties
        public GLCode( String aCode, String aDesc, GLType aType )
        {
            this.Code = aCode;
            this.Desc = aDesc;
            this.Type = aType;
        }

        [OLVColumn("G/L CODE", DisplayIndex = 1, Width = 90, TextAlign = HorizontalAlignment.Center)]
        public String Code
        {
            get;
            set;
        }

        [OLVColumn("Account Description", DisplayIndex = 2, Width = 250, TextAlign = HorizontalAlignment.Left)]
        public String Desc
        {
            get;
            set;
        }

        [OLVColumn("Type", DisplayIndex = 3, Width = 70, TextAlign = HorizontalAlignment.Center)]
        public String TypeStr
        {
            get
            {
                return this.Type.ToString();
            }
        }

        public GLType Type
        {
            get;
            set;
        }

        #endregion
    }
}
