Car c = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
Motorcycle m = new Motorcycle { Brand = "Yamaha", Speed = 150, Type = "Sport" };

c.Start();
c.DisplayInfo();
c.Stop();

m.Start();
m.DisplayInfo();
m.Stop();
