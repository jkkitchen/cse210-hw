using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue", 2);
        // Console.WriteLine(square1.GetColor());
        // Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("green", 4, 2);
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("red", 1);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>
        {
            square1, rectangle1, circle1
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
        
    }
}