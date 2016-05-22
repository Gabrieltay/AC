using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Base
{
    public class Activities
    {
        public enum Action
        {
            // DATA
            INSERT_OBJECT,
            INSERT_OBJECTS,
            UPDATE_OBJECT,
            UPDATE_OBJECTS,
            DELETE_OBJECT,
            DELETE_OBJECTS,
            CLEAR_OBJECTS,

            NULL
        }
    }
}
