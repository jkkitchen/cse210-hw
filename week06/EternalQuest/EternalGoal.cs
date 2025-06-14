using System;

public class EternalGoal : Goal
{
    //No class specific member attributes

    //----Constructor----
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }


    //----Methods----

    //RecordEvent will return the number of points earned
    public override int RecordEvent()
    {
        return _goalPoints;
    }

    //IsComplete will always return false since eternal goals are never comlete
    public override bool IsComplete()
    {
        return false;
    }

    //GetStringRepresentation will order the information to be saved to a text file
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_goalName},{_goalDescription},{_goalPoints}";
    }
}