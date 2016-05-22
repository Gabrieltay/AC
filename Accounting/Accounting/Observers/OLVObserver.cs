using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Base;
using Accounting.Controls;
using Accounting.Model;
using System.Collections;
using BrightIdeasSoftware;

namespace Accounting.Observers
{
    public class OLVObserver : BaseObserver
    {
        public OLVObserver(ObjectListView aObjectListView)
        {
            this.OLV = aObjectListView;
        }

        #region Notifications from Data Model
        public override void update( Activities.Action aAction, object aSubject )
        {
            switch ( aAction )
            {
                case Activities.Action.INSERT_OBJECT:
                    {
                        this.OLV.AddObject(aSubject);
                        this.OLV.BuildList( true );
                        break;
                    }
                case Activities.Action.INSERT_OBJECTS:
                    {
                        this.OLV.AddObjects( (IList)aSubject );
                        break;
                    }
                case Activities.Action.UPDATE_OBJECT:
                    {
                        this.OLV.RefreshObject(aSubject);
                        break;
                    }
                case Activities.Action.UPDATE_OBJECTS:
                    {
                        this.OLV.ClearObjects();
                        this.OLV.AddObjects((IList)aSubject);
                        break;
                    }
                case Activities.Action.DELETE_OBJECT:
                    {
                        this.OLV.RemoveObject( aSubject );
                        break;
                    }
                case Activities.Action.DELETE_OBJECTS:
                    {
                        this.OLV.RemoveObjects( (IList)aSubject );
                        break;
                    }
                case Activities.Action.CLEAR_OBJECTS:
                    {
                        this.OLV.ClearObjects();
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion

        #region Properties
        private ObjectListView OLV
        {
            get;
            set;
        }
        #endregion
    }
}
