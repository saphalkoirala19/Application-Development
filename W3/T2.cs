using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        // Using Ternary Operator
        Console.WriteLine(username == null ? "Username is not available" : username);

        // Using ?? Operator
        Console.WriteLine(username ?? "Username is not available (?? used)");

        // Using ??= Operator
        username ??= "DefaultUser";
        Console.WriteLine("Updated username: " + username);
    }
}

class Program
{
    static void Main(string[] args)
    {
        NullOperations n = new NullOperations();
        n.PerformNullChecks();
    }
}
