using System;

class Program
{
    static void Main(string[] args)
    {
        // For loop, sum from 1 to N
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum from 1 to " + N + " is: " + sum);

        // While loop, skips multiple of 4 and to stop it on 15... 
        int num = 1;
        while (num <= 20)
        {
            if (num == 15)
                break; // stops the loop completely!!
            if (num % 4 == 0)
            {
                num++;
                continue; // skips multiples of 4 here!!!
            }
            Console.Write(num + " ");
            num++;
        }
        Console.WriteLine();

        // Foreach loop, sum of an array elements...
        int[] numbers = { 2, 4, 6, 8, 10 };
        int total = 0;
        foreach (int val in numbers)
        {
            total += val;
        }
        Console.WriteLine("Sum of array elements: " + total);
    }
}
