using System;

public class StartUp
{
    public static void Main()
    {
        var carInfo = Console.ReadLine().Split();
        var fuelQuantity = double.Parse(carInfo[1]);
        var fuelConsumptionPerKm = double.Parse(carInfo[2]);
        var tankCapacity = double.Parse(carInfo[3]);
        Vehicle car = car = new Car(fuelQuantity, fuelConsumptionPerKm, tankCapacity);

        var truckInfo = Console.ReadLine().Split();
        fuelQuantity = double.Parse(truckInfo[1]);
        fuelConsumptionPerKm = double.Parse(truckInfo[2]);
        tankCapacity = double.Parse(truckInfo[3]);
        Vehicle truck = truck = new Truck(fuelQuantity, fuelConsumptionPerKm, tankCapacity);

        var busInfo = Console.ReadLine().Split();
        fuelQuantity = double.Parse(busInfo[1]);
        fuelConsumptionPerKm = double.Parse(busInfo[2]);
        tankCapacity = double.Parse(busInfo[3]);
        Vehicle bus = bus = new Bus(fuelQuantity, fuelConsumptionPerKm, tankCapacity);

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var commandInfo = Console.ReadLine().Split();
            var command = commandInfo[0];
            var vehicleType = commandInfo[1];

            if (vehicleType == "Car")
            {
                ExecuteCommand(car, command, double.Parse(commandInfo[2]));
            }
            else if (vehicleType == "Truck")
            {
                ExecuteCommand(truck, command, double.Parse(commandInfo[2]));
            }
            else if (vehicleType == "Bus")
            {
                ExecuteCommand(bus, command, double.Parse(commandInfo[2]));
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
    }

    private static void ExecuteCommand(Vehicle vehicle, string command, double parameter)
    {
        switch (command)
        {
            case "DriveEmpty":
                Bus bus = (Bus)vehicle;
                Console.WriteLine(bus.DriveEmpty(parameter));
                break;
            case "Drive":
                Console.WriteLine(vehicle.Drive(parameter));
                break;
            case "Refuel":
                try
                {
                    vehicle.Refuel(parameter);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                break;
        }
    }
}