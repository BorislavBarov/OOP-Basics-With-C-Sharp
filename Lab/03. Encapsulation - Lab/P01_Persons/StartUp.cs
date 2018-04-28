using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfInputLines = int.Parse(Console.ReadLine());
        var people = new List<Person>();

        for (int i = 0; i < numberOfInputLines; i++)
        {
            var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstName = inputLine[0];
            var lastName = inputLine[1];
            var age = int.Parse(inputLine[2]);

            var person = new Person(firstName, lastName, age);
            people.Add(person);
        }

        people
            .OrderBy(p => p.FirstName)
            .ThenBy(p => p.Age)
            .ToList()
            .ForEach(p => Console.WriteLine(p.ToString()));
    }
}