public class Entry
{
    //Member Attributes
    public string _dateOfEntry = "";
    public string _journalPrompt = "";
    public string _journalEntryText = "";


    //Constructor
    public Entry()
    {
    }

    //Overriding the "ToString" method and formatting
    //Learned about this when I asked ChatGPT why my file was only saving "Entry" rather than the date, prompt, and entry.
    public override string ToString()
    {
        return $"{_dateOfEntry}|{_journalPrompt}|{_journalEntryText}";
    }

    //Methods
    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateOfEntry}");
        Console.WriteLine($"{_journalPrompt}");
        Console.WriteLine($"{_journalEntryText}");
    }
}