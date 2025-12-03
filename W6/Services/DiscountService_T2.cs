namespace W6.Services;

public class DiscountService
{
    public double FestivalDiscount(double price) => price * 0.80;
    public double SeasonalDiscount(double price) => price * 0.90;
    public double NoDiscount(double price) => price;
}
