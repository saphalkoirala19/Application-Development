namespace W6.Models;

public class CashierSales
{
    public string CashierName { get; }
    public double Amount { get; }

    public CashierSales(string name, double amt)
        => (CashierName, Amount) = (name, amt);
}
