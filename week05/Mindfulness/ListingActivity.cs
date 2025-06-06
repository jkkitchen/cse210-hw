using System;

public class ListingActivity : Activity
{
    //----Member Attributes----    
    private List<string> _listingPrompts;
    private int _count;


    //----Constructor----
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        //Create list of prompts
        _listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        //Initial value of _count is 0 since it is the number of entries the user has made into a list of responses
        _count = 0;
    }


    //Methods

    //Method to get random prompt
    private string GetRandomPrompt()
    {
        //Generate random number to use as index
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 3);

        //Return random prompt using random number as the index
        string randomPrompt = _listingPrompts[number];
        return randomPrompt;
    }

    //Method to run the Listing Activity
    public void ListingActivityRun()
    {
        //Display the starting message and spinner
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine();

        //Set the amount of time the listing program will run
        DateTime listingStartTime = DateTime.Now;
        DateTime listingEndTime = listingStartTime.AddSeconds(_duration);

        //Get and display random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---- {randomPrompt} ----");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);
        Console.WriteLine("\n");

        //Collect responses from user in a list
        List<string> userResponses = new List<string>();

        while (DateTime.Now <= listingEndTime)
        {
            string userResponse = Console.ReadLine();
            userResponses.Add(userResponse);
        }

        //Count the number of responses given and display them
        _count = userResponses.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        //Display the ending message and spinner
        DisplayEndingMessage();
        ShowSpinner(5);

        //Clear the console
        Console.Clear();
    }
}