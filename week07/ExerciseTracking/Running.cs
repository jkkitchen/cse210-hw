using System;
using System.ComponentModel;

public class Running : Exercise
{
    //----Member Variables----
    protected double _distance;


    //----Constructor----
    public Running(int activityLength, double distance) : base(activityLength)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _activityLength = activityLength;
        _distance = distance;
    }


    //----Methods----
    public override string ActivityType()
    {
        return "Running";
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double speed = _distance / _activityLength * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _activityLength / _distance;
        return pace;
    }
}