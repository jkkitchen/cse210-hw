using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int gradePercentage = int.Parse(userInput);
        string letter = "";
        int symbolDeterminer = gradePercentage % 10;
        string symbol = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage < 90 && gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage < 80 && gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage < 70 && gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "A" && letter != "F" && symbolDeterminer >= 7)
        {
            symbol = "+";
        }
        else if (letter != "F" && symbolDeterminer < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

            Console.WriteLine($"{letter}{symbol}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. You'll do better next time!");
        }
    }
}