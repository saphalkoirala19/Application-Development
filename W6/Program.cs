using W6.Models;
using W6.Services;
using W6.Delegates;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  TASK 1  ");
        Rectangle rect = new Rectangle(10, 5);
        Console.WriteLine($"Area: {rect.Area}");
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");

        Console.WriteLine("\n  TASK 2  ");
        MathOps ops = new MathOps();
        Calculate calc = ops.Add;
        Console.WriteLine($"Add: {calc(10, 5)}");
        calc = ops.Subtract;
        Console.WriteLine($"Subtract: {calc(10, 5)}");

        DiscountService ds = new DiscountService();
        Console.WriteLine(CalculateFinalPrice(1000, ds.FestivalDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, ds.SeasonalDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, ds.NoDiscount));
        Console.WriteLine(CalculateFinalPrice(1000, p => p * 0.70));

        Console.WriteLine("\n  TASK 3  ");
        int[] nums = { 2, 5, 12, 15, 20 };
        ProcessNumbers(nums, n => n % 2 == 0);
        ProcessNumbers(nums, n => n > 10);

        Console.WriteLine("\n  TASK 4  ");
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        numbers.Select(n => n * n).ToList().ForEach(Console.WriteLine);

        var books = new List<Book>
        {
            new Book("C# Fundamentals",1500),
            new Book("Java",800),
            new Book("AI",2000)
        };
        books.Where(b => b.Price > 1000).ToList().ForEach(b =>
            Console.WriteLine($"{b.Title} - {b.Price}"));

        var students = new List<Student>
        {
            new Student("Sita"), new Student("Ram"), new Student("Bibek")
        };
        students.OrderBy(s => s.Name).ToList().ForEach(s =>
            Console.WriteLine(s.Name));

        Console.WriteLine("\n  TASK 5  ");
        var sales = new List<CashierSales>
        {
            new CashierSales("A",5000),
            new CashierSales("B",7000),
            new CashierSales("C",4000)
        };
        Console.WriteLine($"Total Cashiers: {sales.Count}");
        Console.WriteLine($"Total Sales: {sales.Sum(s=>s.Amount)}");
        Console.WriteLine($"Max: {sales.Max(s=>s.Amount)}");
        Console.WriteLine($"Min: {sales.Min(s=>s.Amount)}");
        Console.WriteLine($"Avg: {sales.Average(s=>s.Amount)}");

        var apps = new List<Applicant>
        {
            new Applicant("Ram",19),
            new Applicant("Gita",22),
            new Applicant("Hari",17)
        };
        Console.WriteLine(apps.Any(a => a.Age < 18));
        Console.WriteLine(apps.All(a => a.Age > 16));

        var songs = new List<Song>
        {
            new Song("Track1",150),
            new Song("Track2",300),
            new Song("Track3",500)
        };
        Console.WriteLine(songs.First().Duration);
        Console.WriteLine(songs.Last().Duration);
        Console.WriteLine(songs.First(s => s.Duration > 240).Duration);
        Console.WriteLine(songs.FirstOrDefault(s => s.Duration > 600)?.Duration ?? 0);

        Console.WriteLine("\n  TASK 6  ");
        var bookings = new List<TourBooking>
        {
            new TourBooking("A","Tokyo",20000,6,true),
            new TourBooking("B","Pokhara",8000,5,false),
            new TourBooking("C","Thailand",15000,3,true)
        };

        var result = bookings
            .Where(t => t.Price > 10000 && t.DurationInDay > 4)
            .Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                t.Price
            })
            .OrderBy(t => t.Category)
            .ThenBy(t => t.Price);

        foreach (var r in result)
            Console.WriteLine($"{r.CustomerName} | {r.Destination} | {r.Category} | Rs.{r.Price}");
    }

    static void ProcessNumbers(int[] nums, Func<int, bool> cond)
    {
        foreach (var n in nums.Where(cond))
            Console.WriteLine(n);
    }

    static double CalculateFinalPrice(double price, DiscountStrategy ds)
        => ds(price);
}