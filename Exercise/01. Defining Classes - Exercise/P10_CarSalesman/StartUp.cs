using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var engines = new List<Engine>();

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = line[0];
            var power = int.Parse(line[1]);
            var displacement = string.Empty;
            var efficiency = string.Empty;

            var engine = new Engine(model, power);

            if (line.Length == 4)
            {
                displacement = line[2];
                efficiency = line[3];

                engine.Displacement = displacement;
                engine.Efficiency = efficiency;
            }
            else if (line.Length == 3)
            {
                int number;
                if (int.TryParse(line[2], out number))
                {
                    displacement = number.ToString();
                    engine.Displacement = displacement;
                }
                else
                {
                    efficiency = line[2];
                    engine.Efficiency = efficiency;
                }
            }

            engines.Add(engine);
        }

        var m = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < m; i++)
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var model = line[0];
            var engineModel = line[1];
            var engine = engines.Where(e => e.Model == engineModel).FirstOrDefault();
            var weight = string.Empty;
            var color = string.Empty;

            var car = new Car(model, engine);

            if (line.Length == 4)
            {
                weight = line[2];
                color = line[3];

                car.Weight = weight;
                car.Color = color;
            }
            else if (line.Length == 3)
            {
                int number;
                if (int.TryParse(line[2], out number))
                {
                    weight = number.ToString();
                    car.Weight = weight;
                }
                else
                {
                    color = line[2];
                    car.Color = color;
                }
            }

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }
}