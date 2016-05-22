using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounting.Base
{
    public class BaseSubject
    {
        private List<BaseObserver> mObserverList = new List<BaseObserver>();

        public void Subscribe(BaseObserver observer)
        {
            this.mObserverList.Add(observer);
        }

        public void Unsubscribe(BaseObserver observer)
        {
            this.mObserverList.Remove(observer);
        }

        public void Notify(Activities.Action action, object subject = null)
        {
            foreach (BaseObserver observer in this.mObserverList)
                observer.update(action, subject);
        }
    }
}
