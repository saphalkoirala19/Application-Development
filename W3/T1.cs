using System;

public class Operators
{
    // add 2 num
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    // sub 2 num..
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Difference: " + (a - b));
    }

    // Multiply 2 num..
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Product: " + (a * b));
    }

    // divide 2 num 
    public void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine("Division Result: " + ((double)a / b));
        else
            Console.WriteLine("Cannot divide by zero!");
    }

    // check even or odd
    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
        Console.WriteLine(result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Operators op = new Operators();   // obj for Operation class
        op.Add(10, 5);
        op.Subtract(10, 5);
        op.Multiply(10, 5);
        op.Divide(10, 5);
        op.OddEvenFinder(9);
    }
}