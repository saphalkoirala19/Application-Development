namespace W6.Models;

public class TourBooking
{
    public string CustomerName { get; }
    public string Destination { get; }
    public double Price { get; }
    public int DurationInDay { get; }
    public bool IsInternational { get; }

    public TourBooking(string name, string dest, double price, int days, bool intl)
        => (CustomerName, Destination, Price, DurationInDay, IsInternational)
            = (name, dest, price, days, intl);
}
