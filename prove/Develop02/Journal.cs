using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void SearchEntriesByText(string searchText)
{
    bool found = false;
    foreach (Entry entry in _entries)
    {
        if (entry.Text.Contains(searchText, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{entry.Date}: {entry.Text}");
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("No entries found matching the search text.");
    }
}
    
    public void SearchEntriesByDate(DateTime searchDate)
{
    bool found = false;
    foreach (Entry entry in _entries)
    {
        if (entry.Date.Date == searchDate.Date)
        {
            Console.WriteLine($"{entry.Date}: {entry.Text}");
            found = true;
        }
    }
    if (!found)
    {
        Console.WriteLine("No entries found for this date.");
    }
}

}
