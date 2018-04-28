using System;

public class StartUp
{
    public static void Main()
    {
        var startIndex = int.Parse(Console.ReadLine());
        var endIndex = int.Parse(Console.ReadLine());
        var magicNumber = int.Parse(Console.ReadLine());

        var counter = 0;
        bool isFinish = false;

        for (int i = startIndex; i <= endIndex; i++)
        {
            for (int j = startIndex; j <= endIndex; j++)
            {
                counter++;

                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                    isFinish = true;
                    break;
                }
            }

            if (isFinish == true)
            {
                break;
            }
        }

        if (isFinish == false)
        {
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }

    //    var carInfo = Console.ReadLine().Split();
    //    var fuelQuantity = double.Parse(carInfo[1]);
    //    var fuelConsumptionPerKm = double.Parse(carInfo[2]);
    //    Vehicle car = new Car(fuelQuantity, fuelConsumptionPerKm);

    //    var truckInfo = Console.ReadLine().Split();
    //    fuelQuantity = double.Parse(truckInfo[1]);
    //    fuelConsumptionPerKm = double.Parse(truckInfo[2]);
    //    Vehicle truck = new Truck(fuelQuantity, fuelConsumptionPerKm);

    //    var numberOfCommands = int.Parse(Console.ReadLine());

    //    for (int i = 0; i < numberOfCommands; i++)
    //    {
    //        var commandInfo = Console.ReadLine().Split();
    //        var command = commandInfo[0];
    //        var vehicleType = commandInfo[1];

    //        if (vehicleType == "Car")
    //        {
    //            ExecuteAction(car, command, double.Parse(commandInfo[2]));
    //        }
    //        else
    //        {
    //            ExecuteAction(truck, command, double.Parse(commandInfo[2]));
    //        }
    //    }

    //    Console.WriteLine(car);
    //    Console.WriteLine(truck);
    //}

    //private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
    //{
    //    switch (command)
    //    {
    //        case "Drive":
    //            var result = vehicle.Drive(parameter);
    //            Console.WriteLine(result);
    //            break;
    //        case "Refuel":
    //            vehicle.Refuel(parameter);
    //            break;
    //    }
    }
}