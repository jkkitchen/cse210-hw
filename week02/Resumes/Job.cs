using System;

public class Job
{
    //Member Variables:
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    //Constructor:
    public Job()
    {
    }

    //Method to display the variables, formatted correctly:
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}