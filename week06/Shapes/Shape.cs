using System;
using System.Diagnostics.Contracts;

public abstract class Shape
{
    //----Member Attributes----
    protected string _color;

    //----Getter and Setter----
    public string GetColor()
    {
        return _color;
    }

    // public string SetColor(string color)
    // {
    //     _color = color;
    // }

    //----Constructor----
    public Shape(string color)
    {
        _color = color;
    }


    //----Methods----
    public abstract double GetArea();
}