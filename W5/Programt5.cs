ElectronicsStore store = new ElectronicsStore();

Laptop l1 = new Laptop("Dell", 120000);
Smartphone s1 = new Smartphone("Samsung", 80000);

store.AddDevice(l1);
store.AddDevice(s1);

store.ShowAllDeviceDetails();