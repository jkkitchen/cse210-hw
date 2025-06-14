using System;
using System.IO;

public class GoalManager
{
    //----Member Attributes----
    private List<Goal> _goals;
    private int _score;


    //----Constructor----
    public GoalManager()
    {
        //Initial value of the list of goals is empty
        _goals = new List<Goal>();
        //Initial score is 0
        _score = 0;
    }


    //----Methods----

    //Display the number of points the user has
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();
    }

    //Menu options method
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


    //Lists the three different types of goals you can choose from
    static void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }


    //Creates a new goal
    public void CreateGoal()
    {
        ListGoalNames();
        Console.WriteLine("Which type of goal would you like to create? ");
        int userGoalChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //1. Simple Goal
        if (userGoalChoice == 1)
        {
            //Ask user to enter info about the goal:
            Console.Write("What is the name of your goal? ");
            string simpleName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string simpleDescription = Console.ReadLine();
            Console.Write("\nHow many points is this goal worth? ");
            int simplePoints = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Create a SimpleGoal and add it to the list of Goals
            SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
            _goals.Add(simpleGoal);
        }
        //2. Eternal Goal
        else if (userGoalChoice == 2)
        {
            //Ask user to enter info about the goal:
            Console.Write("What is the name of your goal? ");
            string eternalName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string eternalDescription = Console.ReadLine();
            Console.Write("\nHow many points is this goal worth? ");
            int eternalPoints = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Create an EternalGoal and add it to the list of Goals
            EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
            _goals.Add(eternalGoal);
        }
        //3. Checklist Goal
        else if (userGoalChoice == 3)
        {
            //Ask user to enter info about the goal:
            Console.Write("What is the name of your goal? ");
            string checklistName = Console.ReadLine();
            Console.Write("\nWhat is a short description of your goal? ");
            string checklistDescription = Console.ReadLine();
            Console.Write("\nHow many points is this goal worth each time it is completed? ");
            int checklistPoints = int.Parse(Console.ReadLine());
            Console.Write("\nHow many times does this goal need to be accomplished for a bonus? ");
            int _bonusTarget = int.Parse(Console.ReadLine());
            Console.Write("\nWhat is the bonus for accomplishing it that many times? ");
            int _bonusPoints = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Create a Checklist Goal and add it to the list of Goals
            ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, _bonusTarget, _bonusPoints);
            _goals.Add(checklistGoal);
        }
    }


    //List Goals and Details
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        foreach (Goal g in _goals)
        {
            bool isComplete = g.IsComplete();
            int number = _goals.IndexOf(g) + 1;
            Console.WriteLine($"{number}. {g.GetDetailsString(isComplete)}");
        }
    }


    //Save File
    public void SaveGoals()
    {
        //Create file name to save goals
        string filename = "Goals.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //First line of the file will be the score
            outputFile.WriteLine(_score);
            //Following lines will be the goals in _goals
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }


    //Load File and populate _score and _goals
    public void LoadGoals()
    {
        string filename = "Goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        //Get the score from the first line
        _score = int.Parse(lines[0]);

        //Loop through the rest of the lines to create _goals, skip the first line
        foreach (string line in lines.Skip(1))
        {
            //Split on : to get the type of goal and the goal details separated
            string[] parts = line.Split(":");
            string typeOfGoal = parts[0];
            string goalText = parts[1];

            //Use if statement to create new goal and add details to constructor
            if (typeOfGoal == "SimpleGoal")
            {
                //Divide out goal details using commas
                string[] goalAttributes = goalText.Split(",");
                string name = goalAttributes[0];
                string description = goalAttributes[1];
                int points = int.Parse(goalAttributes[2]);
                bool isComplete = bool.Parse(goalAttributes[3]);

                //Create Simple Goal and add it to _goals
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(simpleGoal);
            }
            else if (typeOfGoal == "EternalGoal")
            {
                //Divide out goal details using commas                
                string[] goalAttributes = goalText.Split(",");
                string name = goalAttributes[0];
                string description = goalAttributes[1];
                int points = int.Parse(goalAttributes[2]);
                int numberCompleted = int.Parse(goalAttributes[3]);

                //Create Eternal Goal and add it to _goals
                EternalGoal eternalGoal = new EternalGoal(name, description, points, numberCompleted);
                _goals.Add(eternalGoal);
            }
            else if (typeOfGoal == "ChecklistGoal")
            {
                //Divide out goal details using commas                
                string[] goalAttributes = goalText.Split(",");
                string name = goalAttributes[0];
                string description = goalAttributes[1];
                int points = int.Parse(goalAttributes[2]);
                int bonus = int.Parse(goalAttributes[3]);
                int target = int.Parse(goalAttributes[4]);
                int amountCompleted = int.Parse(goalAttributes[5]);

                //Create Checklist Goal and add it to _goals
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(checklistGoal);
            }
        }
    }


    //Record Event
    public void RecordEvent()
    {
        //List goals for the user to choose from
        Console.WriteLine("The goals are:");
        foreach (Goal g in _goals)
        {
            bool isComplete = g.IsComplete();
            int number = _goals.IndexOf(g) + 1;
            Console.WriteLine($"{number}. {g.GetDetailsString(isComplete)}");
        }
        Console.Write("Which goal did you accomplish? ");
        int userRecordEventChoice = int.Parse(Console.ReadLine());
        //Index will be 1 less than the number the user chooses since the index begins at 0 rather than 1
        Goal goalAccomplished = _goals[userRecordEventChoice - 1];

        //Use Record Event function to get the number of points earned, update the score, and determine if the goal is complete
        int eventPoints = goalAccomplished.RecordEvent();
        _score += eventPoints;

        //Display message to the user
        Console.WriteLine($"Congratulations! You earned {eventPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
    }



    //This method will be called by the program to run everything
    public void StartProgram()
    {
        //Create a variable for the option the user chooses
        int userMenuChoice;

        //Create a loop that will cycle through the menu
        do
        {
            //Display the number of points the player has accumulated
            DisplayPlayerInfo();

            //Display the menu and run the selected activity
            DisplayMenu();
            Console.Write("Select a choice from the menu: ");
            userMenuChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //1. Create New Goal
            if (userMenuChoice == 1)
            {
                CreateGoal();
            }
            //2. List Goals
            else if (userMenuChoice == 2)
            {
                ListGoalDetails();
            }
            //3. Save Goals
            else if (userMenuChoice == 3)
            {
                SaveGoals();
            }
            //4. Load Goals
            else if (userMenuChoice == 4)
            {
                LoadGoals();
            }
            //5. Record Event
            else if (userMenuChoice == 5)
            {
                RecordEvent();
            }
        } while (userMenuChoice != 6);
    }
}