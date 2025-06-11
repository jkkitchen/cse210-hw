using System;

public class Circle : Shape
{
    //----Member Attributes----
    private double _radius;

    //----Constructor----
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    //----Methods----
    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}