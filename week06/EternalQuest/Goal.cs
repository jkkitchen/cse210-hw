using System;

public class Goal
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

    //Will do whatever is necessary for each kind of goal (marking complete, adding to number of times completed, etc.)
    public abstract void RecordEvent();

    //Will return if the goal is completed. This will be different for each type of goal.
    public abstract Boolean IsComplete();

    //Will return the details of a goal that could be shown in a list (checkbox, name, description).
    public virtual string GetDetailsString()
    {
        return $"{_checkbox} {_goalName}, {_goalDescription}";
    }

    //Will provide all the details of a goal in a way that is easy to save to a file.
    public abstract string GetStringRepresentation();
    
}