using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var inputLines = new List<string>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            inputLines.Add(inputLine);
        }

        var animals = new List<IAnimal>();
        IAnimal animal = null;

        for (int i = 0; i < inputLines.Count; i++)
        {
            if (i % 2 == 0)
            {
                var animalInfo = inputLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var type = animalInfo[0];
                var name = animalInfo[1];
                var weight = double.Parse(animalInfo[2]);

                switch (type)
                {
                    case "Cat":
                    case "Tiger":
                        var felineLivingRegion = animalInfo[3];
                        var breed = animalInfo[4];

                        if (type == "Cat")
                        {
                            IAnimal cat = new Cat(name, weight, felineLivingRegion, breed);
                            animal = cat;
                        }
                        else if (type == "Tiger")
                        {
                            IAnimal tiger = new Tiger(name, weight, felineLivingRegion, breed);
                            animal = tiger;
                        }

                        break;

                    case "Owl":
                    case "Hen":
                        var wingSize = double.Parse(animalInfo[3]);
                        
                        if (type == "Owl")
                        {
                            IAnimal owl = new Owl(name, weight, wingSize);
                            animal = owl;
                        }
                        else if (type == "Hen")
                        {
                            IAnimal hen = new Hen(name, weight, wingSize);
                            animal = hen;
                        }

                        break;

                    case "Dog":
                    case "Mouse":
                        var mammalLivingRegion = animalInfo[3];

                        if (type == "Dog")
                        {
                            IAnimal dog = new Dog(name, weight, mammalLivingRegion);
                            animal = dog;
                        }
                        else if (type == "Mouse")
                        {
                            IAnimal mouse = new Mouse(name, weight, mammalLivingRegion);
                            animal = mouse;
                        }

                        break;
                }

                animals.Add(animal);
            }
            else
            {
                var foodInfo = inputLines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var foodType = foodInfo[0];
                var quantity = int.Parse(foodInfo[1]);
                Console.WriteLine(animal.Eat(foodType, quantity));
            }
        }

        foreach (var currentAnimal in animals)
        {
            Console.WriteLine(currentAnimal);
        }
    }
}