using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary10;

namespace Lab13
{
    class JournalEntry
    {
        public string CollectionName;
        public string ChangeType;
        public string ChangedObject;

        public JournalEntry(CollectionHandlerEventArgs info)
        {
            CollectionName = info.Name;
            ChangeType = info.Change;
            ChangedObject = info.ChangedElement.ToString();
        }

        public override string ToString()
        {
            return $@"Изменение в коллекции {CollectionName}
Тип изменения: {ChangeType}
Изменение связано с объектом: {ChangedObject.ToString()}";
        }

    }
}
