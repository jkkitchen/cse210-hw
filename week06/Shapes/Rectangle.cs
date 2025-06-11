using System;
using System.ComponentModel;

public class Rectangle : Shape
{
    //----Member Attributes----
    private double _length;
    private double _width;

    //----Constructor----
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }


    //----Methods----
    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}