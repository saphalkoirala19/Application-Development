using System;

class Program
{
    static void Main(string[] args)
    {
        int[] favNumbers = { 7, 3, 9, 1, 5 };

        Array.Sort(favNumbers);   // Sortig in ascending
        Array.Reverse(favNumbers); // Reverseing it i.e. desending ma..

        Console.WriteLine("Sorted and Reversed Array:");
        for (int i = 0; i < favNumbers.Length; i++)
        {
            Console.WriteLine(favNumbers[i]);
        }

        int position = Array.IndexOf(favNumbers, 5);
        Console.WriteLine($"Position of number 5: {position}");
    }
}
