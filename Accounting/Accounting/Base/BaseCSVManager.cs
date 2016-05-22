using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Accounting.Base
{
    abstract public class BaseCSVManager<T>
    {
        private char[] Delimiters = new char[] { ',' };

        public List<T> Read( String aFilename )
        {
            List<T> nDataList = new List<T>();

            if ( !File.Exists( aFilename ) )
                return nDataList;

            StreamReader mReader = new StreamReader( aFilename );
            String nCurLine = mReader.ReadLine();

            while ( nCurLine != null )
            {
                Regex CSVParser = new Regex( ",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))" );

                String[] nStrArray = CSVParser.Split( nCurLine );

                T nData  = ParseCSV( nStrArray );

                if ( nData == null ) continue;

                nDataList.Add( nData );

                nCurLine = mReader.ReadLine();
            }

            mReader.Dispose();

            return nDataList;
        }

        public void Write( List<T> aDataList, String aFilename )
        {
            StreamWriter mWriter = new StreamWriter( aFilename );
            foreach ( T nObj in aDataList )
            {
                mWriter.Write( WriteCSV(nObj) );
                mWriter.WriteLine();
            }

            mWriter.Dispose();
        }

        abstract protected T ParseCSV(String[] aStrArray);

        abstract protected String WriteCSV( T aObj );
    }
}
