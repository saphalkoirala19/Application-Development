using System;

class Program
{
    static void Main(string[] args)
    {
        byte a = 10;
        short b = 200;
        int c = 3000;
        long d = 40000L;
        float e = 5.5f;
        double f = 9.99;
        decimal g = 15.75m;
        char h = 'S';
        bool i = true;

        // Type conversions
        string numString = 42.ToString();
        double parsedDouble = Convert.ToDouble("3.14");

        // Printing all values
        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"float: {e}");
        Console.WriteLine($"double: {f}");
        Console.WriteLine($"decimal: {g}");
        Console.WriteLine($"char: {h}");
        Console.WriteLine($"bool: {i}");
        Console.WriteLine($"Converted int to string: {numString}");
        Console.WriteLine($"Converted '3.14' to double: {parsedDouble}");
    }
}
