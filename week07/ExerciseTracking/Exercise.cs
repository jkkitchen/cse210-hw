using System;
using System.ComponentModel;

public abstract class Exercise
{
    //----Member Variables----
    protected DateOnly _date;
    protected int _activityLength;


    //----Constructor----
    public Exercise(int activityLength)
    {
        _date = DateOnly.FromDateTime(DateTime.Now);
        _activityLength = activityLength;
    }


    //----Methods----
    public abstract string ActivityType();
    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public void DisplaySummary()
    {
        string activityType = ActivityType();
        double distance = Distance();
        double speed = Speed();
        double pace = Pace();
        Console.WriteLine($"{_date} {activityType} ({_activityLength} min) - Distance: {distance:F2} km, Speed: {speed:F2} kph, Pace: {pace:F2} min/km");
    }


}