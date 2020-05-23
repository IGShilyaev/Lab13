using System;
using ClassLibrary10;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            MyNewCollection coll1 = new MyNewCollection("Первая коллекция", 10);
            MyNewCollection coll2 = new MyNewCollection("Вторая коллекция", 5);

            Journal j1 = new Journal();
            Journal j2 = new Journal();

            coll1.CollectionCountChanged += new CollectionHandler(j1.CollectionChangedHandler);
            coll1.CollectionReferenceChanged += new CollectionHandler(j1.CollectionChangedHandler);
            coll1.CollectionReferenceChanged += new CollectionHandler(j2.CollectionChangedHandler);
            coll2.CollectionReferenceChanged += new CollectionHandler(j2.CollectionChangedHandler);

            coll1.Add(new Organization("AddedOrg", 1960));
            coll1.Remove(6);
            coll1[4] = new Organization("SwapedOrg", 1716);
            coll2[3] = new Organization("AnotherSwapedOrg", 2005);

            Console.WriteLine("Первый журнал:");
            Console.WriteLine(j1.ToString());
            Console.WriteLine();
            Console.WriteLine("Второй журнал:");
            Console.WriteLine(j2.ToString());

        }
    }
}
