using System;
using System.IO; 
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._date = dateText;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine($"Number of entries to display: {_entries.Count}");
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("---------------");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
        foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
   }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry newEntry = new Entry();
            newEntry. _date = parts[0];
            newEntry. _promptText = parts[1];
            newEntry. _entryText = parts[2];

            _entries.Add(newEntry);
            
        }
    }
}