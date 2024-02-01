using System;

public class Journal
{
    // list of journal entries
    public List<Entry> _entries = new List<Entry>();

    // display list of journal entries
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry._entryName);
        }
    }
}