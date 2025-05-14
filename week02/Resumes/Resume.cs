using System;

public class Resume
{
    //Member Variables:
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    //Constructor:
    public Resume()
    {
    }

    //Method to display the variables, formatted correctly:
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job i in _jobs)
        {
            i.Display();
        }
    }    
}