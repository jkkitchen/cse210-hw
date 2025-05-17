using System;
using System.Reflection.Metadata.Ecma335;

class PromptGenerator
{
    //Member Attribute    
    public List<string>prompts = new List<string>();

    //Constructor
    public PromptGenerator()
    {
    }

    //Method
    public string GetRandomPrompt()
    {
        //Generate random number to use as index
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,5);

        //Create list of 5 prompts
        prompts.Add("What was the best part of my day?");
        prompts.Add("What tender mercies did I observe in my life today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("Was there anything that made me laugh today?");
        prompts.Add("Did I accomplish my goals today?");

        //Return random prompt from list
        string journalPrompt = prompts[number];
        return journalPrompt;
    }
}