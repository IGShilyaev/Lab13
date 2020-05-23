using ClassLibrary10;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab13
{
    delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
    class MyNewCollection: MyCollection
    {
        public string Name { get; set; }
        public event CollectionHandler CollectionCountChanged;

        public event CollectionHandler CollectionReferenceChanged;

        public MyNewCollection(string name ,int i)
        {
            Name = name;
            Capacity = i;
            this.Fill();
        }

        public bool Remove(int j)
        {
            if (j >= 0 && j < this.Length)
            {
                CollectionHandlerEventArgs info = new CollectionHandlerEventArgs(this,this[j], "Удален Элемент");
                base.RemoveAt(j);
                OnCountChange(this, info);
                return true; 
            }
            else return false;
        }
        public new void Add(Organization x)
        {
            CollectionHandlerEventArgs info = new CollectionHandlerEventArgs(this,x, "Добавлен Элемент");
            base.Add(x);
            OnCountChange(this, info);
        }

        

        public new Organization this[int index]
        {
            get { return base[index]; }
            set 
            {
                base[index] = value;
                CollectionHandlerEventArgs info = new CollectionHandlerEventArgs(this,value, "Изменение ссылки на элемент");
                OnReferenceChange(this, info);
            }
        }

        public void OnCountChange(object source, CollectionHandlerEventArgs e)
        {
            if (CollectionCountChanged != null) CollectionCountChanged(source, e);
        }

        public void OnReferenceChange(object source, CollectionHandlerEventArgs e)
        {
            if (CollectionReferenceChanged != null) CollectionReferenceChanged(source, e);
        }
   
    }
}
