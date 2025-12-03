namespace W6.Models;

public class Rectangle
{
    public double Length { get; }
    public double Breadth { get; }

    public Rectangle(double l, double b) => (Length, Breadth) = (l, b);

    public double Area => Length * Breadth;
    public double GetPerimeter() => 2 * (Length + Breadth);
}
