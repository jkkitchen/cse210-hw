using System;
using System.IO.Compression;

public class SimpleGoal : Goal
{
    //----Member Attributes----
    protected bool _isComplete;


    //----Constructor----
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        //Initial state of _isComplete is false since when it is first created it won't be complete
        _isComplete = false;
    }

    //Constructor to be used when loading the file
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _isComplete = isComplete;
    }


    //----Methods----

    //RecordEvent will return the number of points earned and mark if the event is complete
    public override int RecordEvent()
    {
        _isComplete = true;
        return _goalPoints;

    }

    //isComplete will return whether or not a goal is completed
    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //GetStringRepresentation will order the information to be saved to a text file
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_goalName},{_goalDescription},{_goalPoints},{_isComplete}";
    }
}