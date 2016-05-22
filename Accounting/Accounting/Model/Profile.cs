using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Accounting.Model
{
    [Serializable]
    public class Profile
    {
        public Profile()
        {
            this.Filename = "";
            this.Client = new Company();
            this.CodeList = new List<GLCode>();
            this.CurDataList = new List<Record>();
            this.PrevDataLists = new Dictionary<string, List<Record>>();
        }

        #region Properties
        public List<GLCode> CodeList
        {
            get;
            set;
        }
        public List<Record> CurDataList
        {
            get;
            set;
        }
        public Dictionary<String, List<Record>> PrevDataLists
        {
            get;
            set;
        }
        public Company Client
        {
            get;
            set;
        }
        public String Filename
        {
            get;
            set;
        }
        #endregion
    }
}
