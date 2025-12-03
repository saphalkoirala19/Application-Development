ParameterDemo p = new ParameterDemo();

// ref example
int val = 5;
p.Increase(ref val);
Console.WriteLine("After Increase: " + val);

// out example
p.GetFullName(out string full);
Console.WriteLine(full);

// params example
int totalSum = p.SumAll(5, 10, 20, 30);
Console.WriteLine("Sum: " + totalSum);
