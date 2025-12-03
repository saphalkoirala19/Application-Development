public class Calculator
{
    // simple welcome message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // returns sum
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // optional parameter num2 = 1
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
