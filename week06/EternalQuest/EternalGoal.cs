using System;

public class EternalGoal : Goal
{
    //For creativity, track the number of times this goal has been completed and give bonus points every 10 times it's completed
    int _numberCompleted;

    //----Constructor----
    //Constructor used to create new goal
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _numberCompleted = 0;
    }

    //Constructor used for loading file
    public EternalGoal(string name, string description, int points, int numberCompleted) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _numberCompleted = numberCompleted;
    }

    //----Methods----

    //RecordEvent will return the number of points earned
    //For creativity, every time the goal has been completed 10 times, the number of points earned on that day will double
    public override int RecordEvent()
    {
        //Add 1 to number completed every time this function is called
        _numberCompleted++;

        //Use if statement to give bonus every 10 times this goal is completed
        if (_numberCompleted % 10 == 0)
        {
            return _goalPoints * 2;
        }
        else
        {
            return _goalPoints;
        }
    }

    //IsComplete will always return false since eternal goals are never comlete
    public override bool IsComplete()
    {
        return false;
    }

    //GetStringRepresentation will order the information to be saved to a text file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName},{_goalDescription},{_goalPoints},{_numberCompleted}";
    }

    //Because of creative addition, the GetStringDetails function needs to be overridden to display the number of times it has been completed
    public override string GetDetailsString(bool isComplete)
    {
        //Create empty variable
        string checkbox;
        //Not really necessary since this goal will always be false, but leaving it here to match other classes
        if (isComplete == false)
        {
            checkbox = "{ }";
        }
        else
        {
            checkbox = "{X}";
        }

        return $"{checkbox} {_goalName} ({_goalDescription}) -- Completed {_numberCompleted} times";
    }
}