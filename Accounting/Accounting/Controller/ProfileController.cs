using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Base;
using Accounting.Model;
using Accounting.Util;

namespace Accounting.Controller
{
    public class ProfileController : BaseSingleton<ProfileController>
    {
        public void Init( Profile aProfile )
        {
            this.Profile = aProfile;
        }

        public void Save( String aFilename )
        {
            Serializer.SaveObjectToFile( this.Profile, aFilename );
        }

        public void Open( String aFilename )
        {
            this.Profile = Serializer.GetObjectFromFile<Profile>( aFilename );
        }

        public void SaveRecords( DataModel<Record> DataList )
        {
            this.Profile.CurDataList = DataList.GetList();
        }

        public void SaveCodes( DataModel<GLCode> DataList )
        {
            this.Profile.CodeList = DataList.GetList();
        }

        #region Properties
        public Profile Profile
        {
            get;
            set;
        }
        #endregion
    }
}
