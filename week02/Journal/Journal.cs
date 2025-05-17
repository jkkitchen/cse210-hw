using System.Runtime.CompilerServices;
using System.IO;
using System.Formats.Asn1;

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

    //Display all Journal Entries
    public void DisplayAll()
    {
        foreach (Entry i in _journalEntries)
        {
            i.DisplayEntry();
        }
    }

    //Save journal entries to a .csv file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            //Saving as .csv file, write CSV header
            outputFile.WriteLine("Date,Prompt,Entry");

            //Write each journal entry as a line
            foreach (Entry j in _journalEntries)
            {
                //Add quotes around fields, escape (double) existing quotes, and add commas
                string date = EscapeCsv(j._dateOfEntry);
                string prompt = EscapeCsv(j._journalPrompt);
                string text = EscapeCsv(j._journalEntryText);


                outputFile.WriteLine($"{date},{prompt},{text}");
            }
        }
    }

    //Additional method that is used in SaveToFile
    //Replaces anything that would mess up the csv formatting or wraps it in quotes
    private string EscapeCsv(string value)
    {
        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
        {
            value = value.Replace("\"", "\"\"");
            value = $"\"{value}\"";
        }
        return value;
    }

    //Loads journal references from file
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entryFromFile = new Entry();
            entryFromFile._dateOfEntry = parts[0];
            entryFromFile._journalPrompt = parts[1];
            entryFromFile._journalEntryText = parts[2];
        }
    }
}