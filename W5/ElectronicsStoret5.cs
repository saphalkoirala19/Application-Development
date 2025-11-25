public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var device in devices)
        {
            device.ShowInfo();

            if (device is Laptop l)
                l.TurnOnBattery();

            if (device is Smartphone s)
                s.EnableCamera();

            Console.WriteLine("--");
        }
    }
}
