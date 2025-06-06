using System;

public class ReflectingActivity : Activity
{
    //----Member Attributes----
    private List<string> _reflectingPrompts;
    private List<string> _reflectingQuestions;


    //----Constructor----
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = @"This activity will help you reflect on times in your life when you have shown strength and resilience. 
This will help you recognize the power you have and how you can use it in other aspects of your life.";

        //Create list of prompts
        _reflectingPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        //Create list of questions
        _reflectingQuestions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself from this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    }


    //----Methods----

    //Method to get random prompt
    private string GetRandomPrompt()
    {
        //Generate random number to use as index
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 3);

        //Return random prompt using random number as the index
        string randomPrompt = _reflectingPrompts[number];
        return randomPrompt;
    }


    //Method to get random question
    private string GetRandomQuestion()
    {
        //Generate random number to use as index
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 8);

        //Return random question using random number as the index
        string randomQuestion = _reflectingQuestions[number];
        return randomQuestion;
    }


    //Method to Display Prompt
    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"----{randomPrompt}----");
        Console.WriteLine();
        Console.Write("Press enter when you are ready to proceed. ");
        Console.ReadLine();
    }


    //Method to Display Question
    private void DisplayQuestions()
    {
        string question1 = GetRandomQuestion();
        Console.Write(question1);
    }


    //Method to run Relflecting Acitivy
    public void ReflectingActivityRun()
    {
        //Display the starting message and spinner
        DisplayStartingMessage();
        ShowSpinner(5);

        //Set the amount of time the reflecting program will run
        DateTime reflectingStartTime = DateTime.Now;
        DateTime reflectingEndTime = reflectingStartTime.AddSeconds(_duration);

        //Display Random Prompt
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        //Clear the screen
        Console.Clear();

        //Display Questions, use loop to continue displaying questions until duration is complete
        while (DateTime.Now <= reflectingEndTime)
        {
            DisplayQuestions();
            ShowSpinner(9);
            Console.WriteLine("\n");
        }

        //Display the ending message and spinner
        DisplayEndingMessage();
        ShowSpinner(5);

        //Clear the console
        Console.Clear();
    }
}