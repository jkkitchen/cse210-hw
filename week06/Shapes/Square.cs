using System;

public class Square : Shape
{
    //----Member Atrributes----
    private double _side;


    //----Constructor----
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //----Methods----
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}