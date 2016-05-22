using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Accounting.Base;
using Accounting.Model;
using Accounting.View;
using Accounting.Util;
using System.Collections;

namespace Accounting.Controller
{
    public class TransactionsController : BaseSingleton<TransactionsController>
    {
        public void Init( DataModel<Record> aModel )
        {
            this.RecordModel = aModel;
        }

        public void AddRecord()
        {
            RecordForm recordForm = new RecordForm();
            recordForm.StartPosition = FormStartPosition.CenterParent;
            recordForm.ShowDialog();

            if ( recordForm.DialogResult == DialogResult.OK )
            {
                this.RecordModel.Add( recordForm.CurRecord );
            }
        }

        public void AddRecords( List<Record> aRecordList )
        {
            this.RecordModel.Add( aRecordList, false );
        }

        public void AddRecords( IEnumerable aRecordList )
        {
            this.RecordModel.Add( aRecordList, false );
        }

        public void EditRecord( Record aRecord )
        {
            RecordForm recordForm = new RecordForm( aRecord );
            recordForm.StartPosition = FormStartPosition.CenterParent;
            recordForm.ShowDialog();

            if ( recordForm.DialogResult == DialogResult.OK )
            {
                this.RecordModel.Edit( recordForm.CurRecord );
            }
        }

        public void DeleteRecords( ArrayList aDeleteList )
        {
            this.RecordModel.Remove( aDeleteList );
        }

        public void LoadRecords( String aFilename )
        {
            if ( aFilename.ToLower().EndsWith( ".rtd" ) )
                this.RecordModel.Add( Serializer.GetListFromFile<Record>( aFilename ), true );
            else if ( aFilename.ToLower().EndsWith( ".csv" ) )
            {
                RecordCSVManager csvManager = new RecordCSVManager();
                this.RecordModel.Add( csvManager.Read( aFilename ), true );
            }
            else
                MessageBox.Show( "Error Msg" );
        }

        public void LoadRecords( List<Record> aRecordList )
        {
            this.RecordModel.Add( aRecordList, true );
        }

        public void SaveRecords( String aFilename )
        {
            Serializer.SaveListToFile<Record>( this.RecordModel.GetList(), aFilename );
        }

        public void ExportCSV( String aFilename )
        {
            RecordCSVManager csvManager = new RecordCSVManager();
            csvManager.Write( this.RecordModel.GetList(), aFilename );
        }

        public void ImportCV( String aFilename )
        {
            RecordCSVManager csvManager = new RecordCSVManager();
            this.RecordModel.Add( csvManager.Read( aFilename ), false );
        }

        public decimal ComputeBalance()
        {
            decimal nOutput = 0;
            foreach ( Record aRecord in this.RecordModel.GetList() )
            {
                nOutput += aRecord.Amount;
            }
            return nOutput;
        }

        public int ComputeCount()
        {
            return this.RecordModel.Size();
        }

        public List<Record> GetList()
        {
            return this.RecordModel.GetList();
        }

        public List<Record> Filter( DateTime nStartDate = default( DateTime ), DateTime nEndDate = default( DateTime ), IList FilterCodes = null )
        {
            List<Record> nFilterList = new List<Record>();
            foreach ( Record nRecord in this.RecordModel.GetList() )
            {
                bool nPass = true;

                // Date Filter
                if ( nStartDate != default( DateTime ) && nEndDate != default( DateTime ) )
                {
                    if ( DateTime.Compare( nRecord.TransDate, nStartDate ) >= 0 &&
                        DateTime.Compare( nRecord.TransDate, nEndDate ) <= 0 )
                    {
                        nPass &= true;
                    }
                    else
                        nPass &= false;
                }

                // Code Filter
                if ( FilterCodes != null )
                {
                    GLCode nCode = CodesController.getInstance().ContainCode( nRecord.GLCode );
                    if ( FilterCodes.Contains( nCode ) )
                    {
                        nPass &= true;
                    }
                    else
                    {
                        nPass &= false;
                    }

                }

                if ( nPass )
                    nFilterList.Add( nRecord );
            }

            return nFilterList;
        }


        #region Properties
        private DataModel<Record> RecordModel
        {
            get;
            set;
        }
        #endregion
    }
}
