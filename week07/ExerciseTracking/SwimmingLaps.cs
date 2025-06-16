using System;

public class SwimmingLaps : Exercise
{
    //----Member Attributes----
    protected double _numberLaps;


    //----Constructor----
    public SwimmingLaps(int activityLength, double numberLaps) : base(activityLength)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _activityLength = activityLength;
        _numberLaps = numberLaps;
    }


    //----Methods----
    public override string ActivityType()
    {
        return "Swimming Laps";
    }

    public override double Distance()
    {
        double distance = _numberLaps * 50 / 1000;
        return distance;
    }

    public override double Speed()
    {
        double speed = (_numberLaps * 50 / 1000) / _activityLength * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _activityLength / (_numberLaps * 50 / 1000);
        return pace;
    }
}