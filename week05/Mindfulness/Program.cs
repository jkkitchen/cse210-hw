using System;

class Program
{
    static void Main(string[] args)
    {
        //Create variable for the menu option the user selects
        int userMenuChoice;

        //Showing creativity by tracking the number of times each activity is done in a session.
        //Create initial values
        int breathingActivityLog = 0;
        int reflectingActivityLog = 0;
        int listingActivityLog = 0;

        //Add a loop to continue displaying the menu until the user selects 4 (quit)
        do
        {
            //Show a log of how many times each exercise has been done this session
            Console.WriteLine("Number of times each exercise has been completed:");
            Console.WriteLine($"Breathing Activity: {breathingActivityLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingActivityLog}");
            Console.WriteLine($"Listing Activity: {listingActivityLog}");
            Console.WriteLine();

            //Display the menu and run the selected activity
            DisplayMenu();
            Console.Write("Please enter the option you have selected: ");
            userMenuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (userMenuChoice == 1)
            {
                //Breathing Activity
                BreathingActivity breathingActivity1 = new BreathingActivity();
                breathingActivity1.BreathingActivityRun();
                breathingActivityLog++;
            }
            else if (userMenuChoice == 2)
            {
                //Reflecting Activity
                ReflectingActivity reflectingActivity1 = new ReflectingActivity();
                reflectingActivity1.ReflectingActivityRun();
                reflectingActivityLog++;
            }
            else if (userMenuChoice == 3)
            {
                //Listing Activity                
                ListingActivity listingActivity1 = new ListingActivity();
                listingActivity1.ListingActivityRun();
                listingActivityLog++;
            }
        } while (userMenuChoice != 4);



        //Menu options method
        static void DisplayMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
        }
    }
}