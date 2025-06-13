using System;

public class GoalManager
{
    //----Member Attributes----
    private List<Goal> _goals;
    private int _score;


    //----Constructor----
    public GoalManager()
    {
        //Initial value of the list of goals is empty
        List<Goal> _goals = new List<Goal>();
        //Initial score is 0
        _score = 0;
    }


    //----Methods----

    //This method will be called by the program to run everything
    //Menu options method
    public void Start()
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }

        //Create a variable for the option the user chooses
        int userMenuChoice;

        //Create a loop that will cycle through the menu
        do
        {
            //Display the number of points the player has accumulated
            Console.WriteLine($"You have {_score} points.");

            //Display the menu and run the selected activity
            DisplayMenu();
            Console.WriteLine("Select a choice from the menu: ");
            userMenuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Main 1. Create New Goal
            if (userMenuChoice == 1)
            {
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("Which type of goal would you like to create? ");
                int userGoalChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //Sub 1. Simple Goal
                if (userGoalChoice == 1)
                {

                }
            }



        } while (userMenuChoice != 6);
    }
}