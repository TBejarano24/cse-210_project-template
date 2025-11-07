using System.IO;

public class Journal
{
    public List<Entry> _entries = new();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new(filename))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date},{item._promptText},{item._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                Entry recoveredEntry = new();
                string[] parts = line.Split(",");

                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];

                recoveredEntry._date = date;
                recoveredEntry._promptText = prompt;
                recoveredEntry._entryText = entry;

                _entries.Add(recoveredEntry);
            }
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine($"Couldn't find {filename}");
        }
    }
}