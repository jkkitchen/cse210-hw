using System;
using System.Diagnostics;
using System.IO;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        //Create journal
        Journal myJournal = new Journal();

        //Create variable for the menu option the user selects
        int userMenuChoice;

        //Add a loop to continue displaying the menu until the user selects 5 (quit)
        do
        {
            //Display the menu
            DisplayMenu();
            Console.Write("Please enter the option you have selected: ");
            userMenuChoice = int.Parse(Console.ReadLine());
            if (userMenuChoice == 1)
            {
                //1. Write a new journal entry.
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
            }
            else if (userMenuChoice == 2)
            {
                //2. Display the journal.
                myJournal.DisplayAll();
            }
            else if (userMenuChoice == 3)
            {
                //3. Save the journal to a file.
                Console.Write("Please enter a filename: ");
                string saveFilename = Console.ReadLine();
                myJournal.SaveToFile(saveFilename);
                Console.WriteLine("File has been saved.");
            }
            else if (userMenuChoice == 4)
            {
                //4. Load the journal from a file.
                Console.Write("Please enter the filename: ");
                string loadFilename = Console.ReadLine();
                myJournal.LoadFromFile(loadFilename);
                Console.WriteLine("File has been loaded.");
            }
        } while (userMenuChoice != 5);



        //Menu options method
        static void DisplayMenu()
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display the journal.");
            Console.WriteLine("3. Save the journal to a file.");
            Console.WriteLine("4. Load the journal from a file.");
            Console.WriteLine("5. Quit.");
        }
    }
}