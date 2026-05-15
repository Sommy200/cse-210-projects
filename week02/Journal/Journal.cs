using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(PromptGen promptGen)
    {
        string prompt = promptGen.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response:");

        string response = Console.ReadLine();

        string dateText = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry();
        newEntry._Date = dateText;
        newEntry._PromptText = prompt;
        newEntry._EntryText = response;

        _entries.Add(newEntry);

        Console.WriteLine("Entry saved");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
            return;
        }

        Console.WriteLine("\n=== Journal Entries ===\n");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // Implementation for saving to file
        Console.Write("Enter the filename to save: ");
        string filename = Console.ReadLine();

        
        // Using StreamWriter to write to a file
        // The 'using' statement ensures the file is properly closed
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._Date}~|~{entry._PromptText}~|~{entry._EntryText}");

            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load:");
        string filename = Console.ReadLine();

        _entries.Clear();
        // Read all lines from the file
        string[] lines = System.IO.File.ReadLines(filename).ToArray();

        foreach (string Line in lines)
        {
           // Split the line at our separator
            string[] parts = Line.Split("~|~"); 

            if (parts.Length == 3)
            {
               // Create a new Entry and fill it from the file data
                Entry entry = new Entry();
                entry._Date = parts[0];
                entry._PromptText = parts[1];
                entry._EntryText = parts[2];
                
                // Add it to our list
                _entries.Add(entry);
            }
        }
        Console.WriteLine($"loaded {_entries.Count} entries from {filename}");
    }
}

    


    
