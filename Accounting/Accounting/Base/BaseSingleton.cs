using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Base
{
    public abstract class BaseSingleton<T>
        where T : BaseSingleton<T>, new()
    {
        private static T msInstance;

        public static T getInstance()
        {
            if ( msInstance == null )
            {
                msInstance = new T();
            }
            return msInstance;
        }
    }
}
