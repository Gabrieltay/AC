using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Base
{
    public abstract class BaseObserver 
    {
        abstract public void update(Activities.Action aAction, object aSubject);
    }
}
