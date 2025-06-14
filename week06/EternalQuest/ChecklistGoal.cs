using System;

public class ChecklistGoal : Goal
{
    //----Member Attributes----
    protected int _amountCompleted;
    protected int _target;
    protected int _bonusPoints;


    //----Constructor----
    //Constructor to be used when creating a new goal
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _amountCompleted = 0;
        _target = target;
        _bonusPoints = bonus;
    }

    //Constructor to be used when loading the file
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonusPoints = bonus;
    }

    //----Methods----

    //RecordEvent will return the number of points earned
    public override int RecordEvent()
    {
        //Add one to _amountCompleted each time this function is called
        _amountCompleted++;

        //Adjust points to account for bonus if the amount completed is equal to the target
        if (_amountCompleted == _target)
        {
            _goalPoints = _goalPoints + _bonusPoints;
        }

        return _goalPoints;
    }

    //Determine if goal is completed
    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Override GetDetailsString to include number of times this goal needs to be completed
    public override string GetDetailsString(bool isComplete)
    {
        //Create empty variable
        string checkbox;
        //Use if statement to determine if it should be marked complete or not (isComplete variable will need to be created using IsComplete Function)
        if (isComplete == false)
        {
            checkbox = "{ }";
        }
        else
        {
            checkbox = "{X}";
        }

        return $"{checkbox} {_goalName} ({_goalDescription}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    //GetStringRepresentation will order the information to be saved to a text file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_goalName},{_goalDescription},{_goalPoints},{_bonusPoints},{_target},{_amountCompleted}";
    }
}