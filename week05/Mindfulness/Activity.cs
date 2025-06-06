using System;

public class Activity
{
    //----Member Attributes----
    protected string _name = "";
    protected string _description = "";
    protected int _duration;

    //----Constructor----
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    //----Methods----

    //Method to display the starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        //Clear the screen, have the "Get Ready" message and the spinner
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    //Method to display the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    //Method to create the spinner used during pauses
    public void ShowSpinner(int seconds)
    {
        //Create a list that contains the four characters used in the spinner.
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        //Set the amount of time that the spinner will run--in this case it will be entered as a value in the method
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        //Use while loop to cycle through the spinner characters for as long as the number of seconds entered into the method
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    //Method to countdown seconds
    public void ShowCountDown(int seconds)
    {
        //Use for loop to replace numbers counting down to 1
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}