using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Model
{
    [Serializable]
    public class Company
    {
        #region Constructors
        public Company()
        {
        }

        public Company( String aName )
        {
            this.Name = aName;
            this.Contact = "";
            this.Address = "";
            this.Registry = "";
        }

        public Company( String aName, String aAddress)
        {
            this.Name = aName;
            this.Address = aAddress;
            this.Contact = "";
            this.Registry = "";
        }

        public Company( String aName, String aAddress, String aContact)
        {
            this.Name = aName;
            this.Address = aAddress;
            this.Contact = aContact;
            this.Registry = "";
        }

        public Company( String aName, String aAddress, String aContact, String aRegistry)
        {
            this.Name = aName;
            this.Address = aAddress;
            this.Contact = aContact;
            this.Registry = aRegistry;
        }
        #endregion

        #region Properties
        public String Name
        {
            get;
            set;
        }

        public String Address
        {
            get;
            set;
        }

        public String Contact
        {
            get;
            set;
        }

        public String Registry
        {
            get;
            set;
        }

        #endregion
    }
}
