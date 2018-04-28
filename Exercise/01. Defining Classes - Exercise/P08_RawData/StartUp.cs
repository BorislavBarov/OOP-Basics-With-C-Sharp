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

            var engineSpeed = int.Parse(line[1]);
            var enginePower = int.Parse(line[2]);

            var cargoWeight = int.Parse(line[3]);
            var cargoType = line[4];

            var thePressureOfTheFirstTire = double.Parse(line[5]);
            var theAgeOfTheFirstTire = int.Parse(line[6]);
            var thePressureOfTheSecondTire = double.Parse(line[7]);
            var theAgeOfTheSecondTire = int.Parse(line[8]);
            var thePressureOfTheThirdTire = double.Parse(line[9]);
            var theAgeOfTheThirdTire = int.Parse(line[10]);
            var thePressureOfTheFourthTire = double.Parse(line[11]);
            var theAgeOfTheFourthTire = int.Parse(line[12]);

            var engine = new Engine(engineSpeed, enginePower);
            var cargo = new Cargo(cargoWeight, cargoType);
            var car = new Car(model, engine, cargo);

            var firstTire = new Tire(thePressureOfTheFirstTire, theAgeOfTheFirstTire);
            var secondTire = new Tire(thePressureOfTheSecondTire, theAgeOfTheSecondTire);
            var thirdTire = new Tire(thePressureOfTheThirdTire, theAgeOfTheThirdTire);
            var fourthTire = new Tire(thePressureOfTheFourthTire, theAgeOfTheFourthTire);

            car.AddTire(firstTire);
            car.AddTire(secondTire);
            car.AddTire(thirdTire);
            car.AddTire(fourthTire);

            cars.Add(car);
        }

        var command = Console.ReadLine();

        if (command == "fragile")
        {
            cars = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).ToList();
        }
        else
        {
            cars = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.Model);
        }
    }
}