using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Accounting.Base;
using Accounting.Model;
using Accounting.View;
using Accounting.Util;
using System.Collections;

namespace Accounting.Controller
{
    public class CodesController : BaseSingleton<CodesController>
    {

        public void Init( DataModel<GLCode> aModel )
        {
            this.CodeModel = aModel;
        }

        public void AddCode( GLCode aCode )
        {
            if ( ContainCode( aCode ) != null )
            {
                this.CodeModel.Remove( ContainCode( aCode ) );
            }

            this.CodeModel.Add( aCode );
        }

        public void AddCodes( List<GLCode> aCodeList )
        {
            this.CodeModel.Add( aCodeList );
        }

        public void EditCode( GLCode aCode )
        {
            this.CodeModel.Edit( aCode );
        }

        public void DeleteCodes( ArrayList aDeleteList )
        {
            this.CodeModel.Remove( aDeleteList );
        }

        public void LoadCodes( String aFilename )
        {
            CodeCSVManager csvManager = new CodeCSVManager();
            this.CodeModel.Add( csvManager.Read( aFilename ) );
        }

        public void LoadCodes( List<GLCode> aCodeList )
        {
            this.CodeModel.Add( aCodeList, true );
        }

        public GLCode ContainCode( GLCode aCode )
        {
            foreach ( GLCode nCode in this.CodeModel.GetList() )
            {
                if ( nCode.Code == aCode.Code )
                    return nCode;
            }
            return null;
        }

        public GLCode ContainCode( String aCodeStr )
        {
            foreach ( GLCode nCode in this.CodeModel.GetList() )
            {
                if ( nCode.Code.Equals(aCodeStr) )
                    return nCode;
            }
            return null;
        }

        public String GetDescription( String aCodeStr )
        {
            foreach ( GLCode nCode in this.CodeModel.GetList() )
            {
                if ( nCode.Code.Equals( aCodeStr ) )
                    return nCode.Desc;
            }
            return "";
        }

        public List<GLCode> GetList()
        {
            return this.CodeModel.GetList();
        }

        public void ExportCSV(String aFilename)
        {
            CodeCSVManager csvManager = new CodeCSVManager();
            csvManager.Write( this.CodeModel.GetList(), aFilename );
        }

        public void ImportCSV( String aFilename )
        {
                LoadCodes( aFilename );
        }

        #region Properties
        private DataModel<GLCode> CodeModel
        {
            get;
            set;
        }
        #endregion
    }
}
