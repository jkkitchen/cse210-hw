using System;

public abstract class Goal
{
    //----Member Attributes----
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoints;

    //----Constructor----
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    //----Methods----

    //RecordEvent will return the number of points earned
    public abstract int RecordEvent();

    //Will return if the goal is completed. This will be different for each type of goal.
    public abstract bool IsComplete();

    //Will return the details of a goal that could be shown in a list (checkbox, name, description). 
    public virtual string GetDetailsString(bool isComplete)
    {
        //Create empty variable
        string checkbox;
        //Use if statement to determine if it should be marked complete or not (variable will be created using IsComplete Function)
        if (isComplete == false)
        {
            checkbox = "{ }";
        }
        else
        {
            checkbox = "{X}";
        }

        return $"{checkbox} {_goalName} ({_goalDescription})";
    }

    //Will provide all the details of a goal in a way that is easy to save to a file.
    public abstract string GetStringRepresentation();

}