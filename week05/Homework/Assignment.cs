using System;

public class Assignment
{
    //----Member Attributes----
    protected string _studentName;
    protected string _topic;


    //----Constructor----
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }


    //----Method----
    public string GetSummary()
    {
        return $"{_studentName} : {_topic}";
    }

}