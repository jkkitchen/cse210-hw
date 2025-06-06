using System;

public class BreathingActivity : Activity
{
    //----No member attributes unique to this activity----

    //----Constructor----
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity wil help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";
    }

    //----Methods----
    public void BreathingActivityRun()
    {
        //Display the starting message and spinner
        DisplayStartingMessage();
        ShowSpinner(5);
        Console.WriteLine();

        //Set the amount of time the breathing program will run
        DateTime breathingStartTime = DateTime.Now;
        DateTime breathingEndTime = breathingStartTime.AddSeconds(_duration);

        //Create loop that will run for the duration of the program
        while (DateTime.Now <= breathingEndTime)
        {
            Console.Write($"Breathe In...");
            ShowCountDown(5);
            Console.Write("\nBreathe Out....");
            ShowCountDown(5);
            Console.WriteLine("\n");
        }

        //Display the ending message and spinner
        DisplayEndingMessage();
        ShowSpinner(5);

        //Clear the console
        Console.Clear();
    }

}