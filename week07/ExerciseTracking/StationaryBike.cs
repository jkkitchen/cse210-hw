using System;

public class StationaryBike : Exercise
{
    //----Member Attributes----
    protected double _speed;


    //----Constructor----
    public StationaryBike(int activityLength, double speed) : base(activityLength)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _activityLength = activityLength;
        _speed = speed;
    }


    //----Methods----
    public override string ActivityType()
    {
        return "Stationary Bike";
    }

    public override double Distance()
    {
        double distance = _speed * _activityLength / 60;
        return distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        double pace = _activityLength / (_speed * _activityLength / 60);
        return pace;
    }
}