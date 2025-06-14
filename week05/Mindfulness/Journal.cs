using System.Collections.Generic;

public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();

    public void AddEntry()
    {
        Console.WriteLine("Write your journal entry:");
        string input = Console.ReadLine();
        _entries.Add(new JournalEntry(input));
        Console.WriteLine("Entry saved.");
    }

    public void ViewEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries yet.");
            return;
        }

        Console.WriteLine("Your Journal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}