using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var citizensAndPets = new List<IBirthdate>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            var tokens = inputLine.Split();

            if (tokens[0] == "Pet")
            {
                var name = tokens[1];
                var birthdate = DateTime.ParseExact(tokens[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var pet = new Pet(name, birthdate);
                citizensAndPets.Add(pet);
            }
            else if (tokens[0] == "Citizen")
            {
                var name = tokens[1];
                var age = int.Parse(tokens[2]);
                var id = tokens[3];
                var birthdate = DateTime.ParseExact(tokens[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var citizen = new Citizen(name, age, id, birthdate);
                citizensAndPets.Add(citizen);
            }
        }

        var year = int.Parse(Console.ReadLine());
        var theChoosenOnes = citizensAndPets.Select(x => x.Birthdate).Where(x => x.Year == year).ToList();

        foreach (var currentDate in theChoosenOnes)
        {
            var date = currentDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date);
        }
    }
}