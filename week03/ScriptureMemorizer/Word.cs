using System;
using System.Security.Cryptography.X509Certificates;

public class Word
{
    //----Member Attributes----
    private string _text;
    private Boolean _isHidden;




    //----Constructor----
    public Word(string text)
    {
        _text = text;
        //Because we are setting the intial value, _isHidden is false since all the words will be shown initially
        _isHidden = false;
    }




    //----Methods----

    //Method to change _isHidden to true.
    public void Hide()
    {
        _isHidden = true;
    }

    //Method to show words--not sure why we need this?
    public void Show()
    {
        _isHidden = false;
    }

    //Method to tell if words are hidden
    public Boolean IsHidden()
    {
        if (_isHidden == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Method to Display Text
    public string GetDisplayText()
    {
        if (_isHidden == false)
        {            
            return _text + " ";
        }
        else
        {
            //Determine length of word that will be hidden
            int lengthOfWord = _text.Length;
            //Set an intial value that will be filled in with _ characters for as many letters as are in the word
            string hiddenWord = "";
            //Use for loop to create hidden word
            for (int i = 0; i < lengthOfWord; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord + " ";
        }        
    }
}