using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var cars = new List<Car>();
        var lines = int.Parse(Console.ReadLine());

        for (int i = 0; i < lines; i++)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = parameters[0];
            var car = new Car(model);

            var engineSpeed = int.Parse(parameters[1]);
            var enginePower = int.Parse(parameters[2]);
            var engine = new Engine(engineSpeed, enginePower);

            var cargoWeight = int.Parse(parameters[3]);
            var cargoType = parameters[4];
            var cargo = new Cargo(cargoWeight, cargoType);

            var tire1Pressure = double.Parse(parameters[5]);
            var tire1age = int.Parse(parameters[6]);
            var tire2Pressure = double.Parse(parameters[7]);
            var tire2age = int.Parse(parameters[8]);
            var tire3Pressure = double.Parse(parameters[9]);
            var tire3age = int.Parse(parameters[10]);
            var tire4Pressure = double.Parse(parameters[11]);
            var tire4age = int.Parse(parameters[12]);
            var tire = new Tire(tire1Pressure, tire1age, tire2Pressure, tire2age, tire3Pressure, tire3age, tire4Pressure, tire4age);

            car.Engine = engine;
            car.Cargo = cargo;
            car.Tire = tire;

            cars.Add(car);
        }

        string command = Console.ReadLine();
        if (command == "fragile")
        {
            List<string> fragile = cars
                .Where(x => x.Cargo.CargoType == "fragile" && x.Tire.Tires.Any(y => y.Key < 1))
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            List<string> flamable = cars
                .Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }
}