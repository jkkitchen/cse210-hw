using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    //Member Variables:
    public List<Entry> _journalEntries = new List<Entry>();

    //Constructor
    public Journal()
    {
    }

    //Methods

    //Add a new journal entry
    public void AddEntry(Entry journalEntry)
    {
        //Get the date
        DateTime theCurrentTime = DateTime.Now;
        journalEntry._dateOfEntry = theCurrentTime.ToShortDateString();

        //Get and display a random prompt
        PromptGenerator generator = new PromptGenerator();
        journalEntry._journalPrompt = generator.GetRandomPrompt();
        Console.WriteLine(journalEntry._journalPrompt);

        //Read in the text that is entered by the user for the body of the entry
        journalEntry._journalEntryText = Console.ReadLine();

        //Add to the list of journal entries
        _journalEntries.Add(journalEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry i in _journalEntries)
        {
            i.DisplayEntry();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry j in _journalEntries)
            {
                outputFile.WriteLine(j);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entryFromFile = new Entry();
            entryFromFile._dateOfEntry = parts[0];
            entryFromFile._journalPrompt = parts[1];
            entryFromFile._journalEntryText = parts[2];
        }
    }
}