using System;

class Program
{
    static void Main(string[] args)
    {
        //Define empty list to contain exercises
        List<Exercise> exercises = new List<Exercise>();

        //Add one of each type of exercise to the list
        Running run1 = new Running(60, 12);
        exercises.Add(run1);
        Running run2 = new Running(30, 7);
        exercises.Add(run2);
        StationaryBike bike1 = new StationaryBike(45, 20);
        exercises.Add(bike1);
        SwimmingLaps swim1 = new SwimmingLaps(50, 50);
        exercises.Add(swim1);

        //Use a loop to iterate through the list and display a summary
        foreach (Exercise e in exercises)
        {
            e.DisplaySummary();
        }
    }
}