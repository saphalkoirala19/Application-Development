using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List Example
        List<string> fruits = new List<string>() { "Apple", "Banana", "Mango" };
        fruits.Add("Orange");
        fruits.Remove("Banana");

        Console.WriteLine("Fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Dictionary Example
        Dictionary<int, string> fruitDict = new Dictionary<int, string>()
        {
            { 1, "Apple" },
            { 2, "Mango" },
            { 3, "Orange" }
        };

        fruitDict.Add(4, "Grapes");

        Console.WriteLine("\nFruit Dictionary:");
        foreach (var pair in fruitDict)
        {
            Console.WriteLine($"ID: {pair.Key} → Name: {pair.Value}");
        }
    }
}
