using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2003, 10, 29); // For Example
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Your age: {ageInYears} years");

        DateTime futureDate = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate after 10 days: {futureDate.ToShortDateString()}");
    }
}
