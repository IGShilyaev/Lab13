using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Journal
    {
        private List<JournalEntry> journalEntries;

        public Journal()
        {
            journalEntries = new List<JournalEntry>();
        }

        public void CollectionChangedHandler(object source, CollectionHandlerEventArgs e)
        {
            JournalEntry newEntry = new JournalEntry(e);
            journalEntries.Add(newEntry);
        }

        public override string ToString()
        {
            string temp = "";
            foreach (JournalEntry x in journalEntries) temp += x.ToString() + "\n\n";
            return temp;
        }
    }
}
