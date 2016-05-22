using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Util;

namespace Accounting.Controller
{
    public static class RegistryController
    {
        private static RegistryEditor nRegEdit = new RegistryEditor( "SOFTWARE\\GTAccounts\\Data" );

        private static readonly String FILENAME_1 = "_FILENAME_1";
        private static readonly String FILENAME_2 = "_FILENAME_2";
        private static readonly String FILENAME_3 = "_FILENAME_3";
        private static readonly String FILENAME_4 = "_FILENAME_4";
        private static readonly String FILENAME_5 = "_FILENAME_5";

        public static void Add( String aFilename )
        {
            if ( Filename1.Equals( aFilename ) ||
                Filename2.Equals( aFilename ) ||
                Filename3.Equals( aFilename ) ||
                Filename4.Equals( aFilename ) ||
                Filename5.Equals( aFilename ) )
                return;
            Filename1 = aFilename;
        }

        public static void Remove( String aFilename )
        {
            if ( Filename1.Equals( aFilename ) )
                Filename1 = "";
            else if ( Filename2.Equals( aFilename ) )
                Filename2 = "";
            else if ( Filename3.Equals( aFilename ) )
                Filename3 = "";
            else if ( Filename4.Equals( aFilename ) )
                Filename4 = "";
            else if ( Filename5.Equals( aFilename ) )
                Filename5 = "";
        }

        public static List<String> GetRecents()
        {
            List<String> nRecentList = new List<string>();
            if ( !String.IsNullOrEmpty( Filename1 ) )
                nRecentList.Add( Filename1 );
            if ( !String.IsNullOrEmpty( Filename2 ) )
                nRecentList.Add( Filename2 );
            if ( !String.IsNullOrEmpty( Filename3 ) )
                nRecentList.Add( Filename3 );
            if ( !String.IsNullOrEmpty( Filename4 ) )
                nRecentList.Add( Filename4 );
            if ( !String.IsNullOrEmpty( Filename5 ) )
                nRecentList.Add( Filename5 );
            return nRecentList;
        }

        private static String Filename1
        {
            get
            {
                String temp = nRegEdit.Read( FILENAME_1 );
                return ( ( String.IsNullOrEmpty(temp) ) ? "" : temp );
            }
            set
            {
                Filename2 = Filename1;
                nRegEdit.Write( FILENAME_1, value );
            }
        }

        private static String Filename2
        {
            get
            {
                String temp = nRegEdit.Read( FILENAME_2 );
                return ( ( String.IsNullOrEmpty(temp) ) ? "" : temp );
            }
            set
            {
                Filename3 = Filename2;
                nRegEdit.Write( FILENAME_2, value );
            }
        }

        private static String Filename3
        {
            get
            {
                String temp = nRegEdit.Read( FILENAME_3 );
                return ( ( String.IsNullOrEmpty( temp ) ) ? "" : temp );
            }
            set
            {
                Filename4 = Filename3;
                nRegEdit.Write( FILENAME_3, value );
            }
        }

        private static String Filename4
        {
            get
            {
                String temp = nRegEdit.Read( FILENAME_4 );
                return ( ( String.IsNullOrEmpty( temp ) ) ? "" : temp );
            }
            set
            {
                Filename5 = Filename4;
                nRegEdit.Write( FILENAME_4, value );
            }
        }

        private static String Filename5
        {
            get
            {
                String temp = nRegEdit.Read( FILENAME_5 );
                return ( ( String.IsNullOrEmpty( temp ) ) ? "" : temp );
            }
            set
            {
                nRegEdit.Write( FILENAME_5, value );
            }
        }


    }
}
