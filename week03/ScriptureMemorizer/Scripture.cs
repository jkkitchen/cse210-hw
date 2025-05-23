using System;
using System.Globalization;

public class Scripture
{
    //----Member Attributes----
    private Reference _reference;
    private List<Word> _words;




    //----Constructor----
    public Scripture(Reference reference, string scriptureText)
    {
        //Reference:
        _reference = reference;

        //Words:
        //Split up the words in the verse and put them in a List of strings.
        string[] scriptureArray = scriptureText.Split(' ');
        List<string> scriptureWords = new List<string>(scriptureArray);

        //Find the number of words in the list (verses) using the Count property
        int numberWords = scriptureWords.Count;

        //Create a list of Word objects to store each word in the verses as a Word object;
        _words = new List<Word>();

        //Use a for loop to iterate through the List<strings> containing the scripture text and create a Word object for each word in the verses. The Boolean 
        // will be false since we are showing the initial state of each word and all words wil be shown at the beginning. This means that we don't have to 
        // include it in our Word object since the default Word constructor with one value provided is for the Boolean to be false.
        for (int i = 0; i < numberWords; i++)
        {
            Word word = new Word(scriptureWords[i]);
            _words.Add(word);
        }
    }




    //----Methods----

    //Method to hide words
    public void HideRandomWords(int numberToHide)
    {
        //Use loop to iterate through all the words in the verse and hide numberToHide words from the scripture
        for (int j = 0; j < numberToHide; j++)
        {
            //Determine range of random numbers
            int randomNumberRange = _words.Count;

            //Generate random number to use as index
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, randomNumberRange);

            //Call Word from list
            Word wordToHide = _words[number];

            //Hide word
            wordToHide.Hide();
        }
    }


    //Method to display reference and scripture verse together.
    public string GetDisplayText()
    {
        //Pull reference display and word display for each word in list.
        string scriptureVerse = "";

        foreach (Word word in _words)
        {
            scriptureVerse += word.GetDisplayText();
        }

        return $"{_reference.GetDisplayText()} {scriptureVerse}";
    }



    //Method to determine if the verse(s) is completely hidden.
    public Boolean IsCompletelyHidden()
    {
        //Set up initial count
        int numberOfWordsShown = 0;

        //Iterate through list of Word objects and count the number of _isHidden's that are True.
        int numberWords = _words.Count;
        for (int j = 0; j < (numberWords - 1); j++)
        {
            Word wordCheck = _words[j];
            Boolean falseCheck = wordCheck.IsHidden();
            if (falseCheck == false)
            {
                numberOfWordsShown++;
            }
        }

        //Return value for IsCompletelyHidden
        if (numberOfWordsShown != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}