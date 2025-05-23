using System;

public class Reference
{
    //----Member Attributes----
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;




    //----Constructors----
    //Single Verse Constructor
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }

    //Multiple Verse Constructor
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }




    //----Methods----
    //Display Reference
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            string displayReference = $"{_book} {_chapter}:{_verse}";
            return displayReference;
        }
        else
        {
            string displayReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return displayReference;
        }
    }
}