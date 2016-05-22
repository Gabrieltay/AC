using System;
using System.Collections.Generic;
using System.Linq;
using Accounting.View;
using Accounting.Base;

namespace Accounting.Observers
{
    public class CodeFormObserver : BaseObserver
    {
        public CodeFormObserver( CodeForm aForm )
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
                    {
                        this.Form.ClearForm();
                        break;
                    }
                default:
                    break;
            }
        }
        #endregion

        #region Properties
        private CodeForm Form
        {
            get;
            set;
        }
        #endregion
    }
}
