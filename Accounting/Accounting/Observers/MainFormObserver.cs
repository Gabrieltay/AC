using System;
using System.Collections.Generic;
using System.Linq;
using Accounting.Controller;
using Accounting.View;
using Accounting.Base;

namespace Accounting.Observers
{
    public class MainFormObserver : BaseObserver
    {
        public MainFormObserver( MainForm aForm )
        {
            this.Form = aForm;
        }

        #region Notifications from Data Model
        public override void update( Activities.Action aAction, object aSubject )
        {
            switch ( aAction )
            {
                case Activities.Action.INSERT_OBJECT:
                case Activities.Action.INSERT_OBJECTS:
                case Activities.Action.UPDATE_OBJECT:
                case Activities.Action.UPDATE_OBJECTS:
                case Activities.Action.DELETE_OBJECT:
                case Activities.Action.DELETE_OBJECTS:
                case Activities.Action.CLEAR_OBJECTS:   
                    {
                        this.Form.UpdateBalance( String.Format( "{0:C}", TransactionsController.getInstance().ComputeBalance() ) );
                        this.Form.UpdateCount( TransactionsController.getInstance().ComputeCount() );
                        this.Form.UpdateStatus( "Ready" );
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion

        #region Properties
        private MainForm Form
        {
            get;
            set;
        }
        #endregion
    }
}
