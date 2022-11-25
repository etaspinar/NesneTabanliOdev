using Inheritance_lab;

Vehicle vehicle = new Vehicle();
vehicle.Engine = 7.6;
vehicle.NumberOfWeel = 4;
vehicle.Transmission = "auto";
vehicle.Model = "Ford";
vehicle.Price = 100000;

Console.WriteLine(vehicle.ToString());
vehicle.Start();
Console.WriteLine("\n");

Car car = new Car(3.3, 4, "BMW", 200000, "auto");
Bus bus = new Bus(4.6, 10, "Mercedes", 500000, "manuel");
Truck truck = new Truck(4.9,12, "Volvo", 2000000, "manuel");

Console.WriteLine(car.Transmission);
Console.WriteLine(bus.Model);
Console.WriteLine(truck.NumberOfWeel);
Console.WriteLine("\n");

List<Vehicle> list = new List<Vehicle>();
list.Add(car);
list.Add(bus);
list.Add(truck);

foreach (var item in list)
{
    Console.WriteLine(item + "\n");
}


