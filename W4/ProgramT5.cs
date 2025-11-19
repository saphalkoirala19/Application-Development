Console.Write("Enter day: ");
string dayInput = Console.ReadLine().ToLower();

if (dayInput == "friday" || dayInput == "saturday")
{
    Console.WriteLine("It is: Weekend");
}
else
{
    Console.WriteLine("It is: Weekday");
}

// book object
Book b1 = new Book("Atomic Habits", "James Clear", 20.50);

// using with expression
Book b2 = b1 with { title = "Rich Dad Poor Dad", price = 15.99 };

Console.WriteLine(b1);

// deconstruction
var (t, a, p) = b2;
Console.WriteLine(t);
Console.WriteLine(a);
Console.WriteLine(p);