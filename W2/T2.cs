using System;

public class Circle
{
    public const double PI = 3.14;   // cause constant variable can't be changed..

    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle c = new Circle();

        // The following line will cause a compilation error if uncommented:
        // Circle.PI = 3.14159; 

        Console.WriteLine("Area: " + c.CalculateArea(5));
        Console.WriteLine("Perimeter: " + c.CalculatePerimeter(5));
    }
}
