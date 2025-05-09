using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            int guesses = 1;

            while (userGuess != magicNumber)
            {
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guesses = guesses + 1;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guesses} tries.");

            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "Yes");
    }
}