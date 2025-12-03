namespace W6.Models;

public class Book
{
    public string Title { get; }
    public double Price { get; }

    public Book(string title, double price)
        => (Title, Price) = (title, price);
}
