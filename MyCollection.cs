using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary10;

namespace Lab13
{
    class MyCollection : List<Organization>
    {
        public int Length
        {
            get
            {
            return this.Count;
            }
        }
        
        public void Fill()
        {
            for (int i = 0; i< this.Capacity; i++)
            {
                Organization temp = new Organization($"Org {i+1}", 450 + 10*i);
                this.Add(temp);
            }
        }

    }
}
