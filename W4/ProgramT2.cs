Calculator calc = new Calculator();

calc.PrintWelcome();

int addResult = calc.Add(10, 5);
Console.WriteLine("Addition: " + addResult);

int mul1 = calc.Multiply(6);
int mul2 = calc.Multiply(6, 4);

Console.WriteLine("Multiply (default): " + mul1);
Console.WriteLine("Multiply: " + mul2);