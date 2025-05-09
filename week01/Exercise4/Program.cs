using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber;

        do
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        int sumNumbers = 0;
        float avgNumbers = 0;
        int maxNumber = -10000;
        int smallestPositiveNumber = 100000;

        for (int i = 0; i < numbers.Count; i++)
        {
            sumNumbers = sumNumbers + numbers[i];
            avgNumbers = ((float)sumNumbers) / numbers.Count;
            if (maxNumber < numbers[i])
            {
                maxNumber = numbers[i];
            }
            if (numbers[i] > 0 && smallestPositiveNumber > numbers[i])
            {
                smallestPositiveNumber = numbers[i];
            }
        }

        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {avgNumbers}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        numbers.Sort();

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}