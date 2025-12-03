Console.Write("Enter marks: ");
int.TryParse(Console.ReadLine(), out int marks);

Console.Write("Enter total: ");
int.TryParse(Console.ReadLine(), out int total);

// converting to double to avoid integer division
double percentage = ((double)marks / total) * 100;

Console.WriteLine("Percentage: " + percentage);
