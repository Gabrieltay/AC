using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounting.Base;
using Accounting.Observers;
using BrightIdeasSoftware;
using System.Collections;
using System.Windows.Forms;

namespace Accounting.Model
{
    public class DataModel<T> : BaseSubject
    {
        public DataModel()
        {
            this.DataList = new List<T>();
        }

        public DataModel( List<T> DataList )
        {
            this.DataList = DataList;
            Notify( Activities.Action.UPDATE_OBJECTS, this.DataList );
        }

        public void Add(T aObj)
        {
            this.DataList.Add(aObj);
            Notify(Activities.Action.INSERT_OBJECT, aObj);
        }

        public void Add(List<T> aObjList)
        {
            this.Add(aObjList, false);
            Notify( Activities.Action.INSERT_OBJECTS, aObjList );
        }

        public void Add(IEnumerable aObjList, bool aOverwrite)
        {
            if (aOverwrite)
            {
                this.DataList = (List<T>)(aObjList);
                Notify(Activities.Action.UPDATE_OBJECTS, this.DataList);
            }
            else
            {
                this.DataList.AddRange( (aObjList.OfType<T>()) );
                Notify(Activities.Action.INSERT_OBJECTS, aObjList);
            }
        }

        public void Edit(T aObj)
        {
            Notify(Activities.Action.UPDATE_OBJECT, aObj);
        }

        public void Remove( T aObj )
        {
            this.DataList.Remove( aObj );
            Notify( Activities.Action.DELETE_OBJECT, aObj );
        }

        public void Remove( ArrayList aDeleteList )
        {
            foreach (T nDelObj in aDeleteList)
            {
                int objIndex = this.DataList.IndexOf(nDelObj);
                if (objIndex >= 0)
                    this.DataList.RemoveAt(objIndex);
            }
            Notify( Activities.Action.DELETE_OBJECTS, aDeleteList );
        }

        public void Clear()
        {
            this.DataList.Clear();
            Notify( Activities.Action.CLEAR_OBJECTS );
        }

        public int Size()
        {
            return this.DataList.Count;
        }

        public List<T> GetList()
        {
            return this.DataList;
        }

        #region Properties
        private List<T> DataList
        {
            get;
            set;
        }
        #endregion
    }
}
