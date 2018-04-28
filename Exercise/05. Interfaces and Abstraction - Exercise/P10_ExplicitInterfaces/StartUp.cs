using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var citizens = new List<Citizen>();

        string line;
        while ((line = Console.ReadLine()) != "End")
        {
            var citizenInfo = line.Split();

            var name = citizenInfo[0];
            var country = citizenInfo[1];
            var age = int.Parse(citizenInfo[2]);

            var citizen = new Citizen(name, country, age);
            citizens.Add(citizen);
        }

        foreach (var citizen in citizens)
        {
            var person = (IPerson)citizen;
            var resident = (IResident)citizen;

            Console.WriteLine(person.GetName());
            Console.WriteLine(resident.GetName());
        }
    }
}