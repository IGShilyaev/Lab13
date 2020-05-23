using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using ClassLibrary10;

namespace Lab13
{
    class CollectionHandlerEventArgs: EventArgs
    {
        public string Name { get; set; }
        public string Change { get; set; }
        public Organization ChangedElement { get; set; }

        public CollectionHandlerEventArgs(MyNewCollection coll, Organization org, string changeInfo)
        {
            ChangedElement = org;
            Name = coll.Name;
            Change = changeInfo;
        }

        public override string ToString()
        {
            return ChangedElement.ToString();
        }

    }
}
