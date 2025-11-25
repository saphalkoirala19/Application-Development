public class Motorcycle : Vehicle
{
    public string Type { get; set; }  // Example unique field

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Type: " + Type);
    }
}
