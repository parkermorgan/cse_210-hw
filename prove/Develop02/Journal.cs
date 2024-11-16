using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private PromptGenerator _promptGenerator;

    public Journal(PromptGenerator promptGenerator)
    {
        _promptGenerator = promptGenerator;
    }
    
    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GetDate();
        newEntry.SetPrompt(_promptGenerator);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries available.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();  // Display each entry's details
            Console.WriteLine();
        }
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the name of the file to load from (e.g., journal.csv): ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string entryText = parts[2];

                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _promptText = prompt,
                        _entryText = entryText
                    };

                    _entries.Add(newEntry);
                }
            }
            Console.WriteLine($"Journal entries have been loaded from {fileName}.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveToFile()
{
    Console.Write("Enter the name of the file to save to (e.g., journal.csv): ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.WriteLine("Date,Prompt,EntryText");  // Header row for CSV

        // Loop through each entry in the list and save to file
        foreach (Entry entry in _entries)
        {
            string csvLine = $"{entry._date},{EscapeCsv(entry._promptText)},{EscapeCsv(entry._entryText)}";
            writer.WriteLine(csvLine);
        }
    }

    Console.WriteLine($"Entries saved to {fileName}.");
}

    private string EscapeCsv(string input)
    {
        return input.Replace("\"", "\"\""); // Escape double quotes by doubling them
    }
}