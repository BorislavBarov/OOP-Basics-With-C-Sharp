using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = line[0];
            var fuelAmount = double.Parse(line[1]);
            var fuelConsumptionForOneKm = double.Parse(line[2]);

            var car = new Car(model, fuelAmount, fuelConsumptionForOneKm);
            cars.Add(car);
        }

        string commandLine;

        while ((commandLine = Console.ReadLine()) != "End")
        {
            var commandParts = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = commandParts[1];
            var amountOfKm = int.Parse(commandParts[2]);

            var currentCar = cars.Where(c => c.Model == model).SingleOrDefault();

            currentCar.Drive(amountOfKm);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}