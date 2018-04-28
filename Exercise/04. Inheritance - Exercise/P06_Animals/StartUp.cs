using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        string command;
        while ((command = Console.ReadLine()) != "Beast!")
        {
            var animalInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                switch (command)
                {
                    case "Dog":
                        var dogName = animalInfo[0];
                        var dogAge = int.Parse(animalInfo[1]);
                        var dogGender = animalInfo[2];
                        Animal dog = new Dog(dogName, dogAge, dogGender);
                        Console.WriteLine(dog);
                        break;
                    case "Cat":
                        var catName = animalInfo[0];
                        var catAge = int.Parse(animalInfo[1]);
                        var catGender = animalInfo[2];
                        Animal cat = new Cat(catName, catAge, catGender);
                        Console.WriteLine(cat);
                        break;
                    case "Frog":
                        var frogName = animalInfo[0];
                        var frogAge = int.Parse(animalInfo[1]);
                        var frogGender = animalInfo[2];
                        Animal frog = new Frog(frogName, frogAge, frogGender);
                        Console.WriteLine(frog);
                        break;
                    case "Kitten":
                        var kittenName = animalInfo[0];
                        var kittenAge = int.Parse(animalInfo[1]);
                        Animal kitten = new Kitten(kittenName, kittenAge, "Female");
                        Console.WriteLine(kitten);
                        break;
                    case "Tomcat":
                        var tomcatName = animalInfo[0];
                        var tomcatAge = int.Parse(animalInfo[1]);
                        Animal tomcat = new Tomcat(tomcatName, tomcatAge, "Male");
                        Console.WriteLine(tomcat);
                        break;
                    default:
                        throw new ArgumentException("Invalid input!");
                }
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}