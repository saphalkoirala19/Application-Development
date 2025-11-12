using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 – Exception Handling
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + num);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        // Part 2 – Throw Exception for Password Length
        try
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");
            else
                Console.WriteLine("Password satisfied the requirement.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
