using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = inputParts[0];
            var parameters = inputParts.Skip(1).ToArray();
            var person = people.FirstOrDefault(p => p.Name == name);

            if (person == null)
            {
                person = new Person(name);
                ProcessCommand(parameters, person);
                people.Add(person);
            }
            else
            {
                ProcessCommand(parameters, person);
            }
        }

        var inputName = Console.ReadLine();
        var printPerson = people.FirstOrDefault(p => p.Name == inputName);

        Console.WriteLine(printPerson.ToString());
    }

    private static void ProcessCommand(string[] parameters, Person person)
    {
        var command = parameters[0];

        switch (command)
        {
            case "company":
                var companyName = parameters[1];
                var department = parameters[2];
                var salary = decimal.Parse(parameters[3]);

                var company = new Company(companyName, department, salary);
                person.Company = company;

                break;

            case "pokemon":
                var pokemonName = parameters[1];
                var pokemonType = parameters[2];

                var pokemon = new Pokemon(pokemonName, pokemonType);
                person.AddPokemon(pokemon);

                break;

            case "parents":
                var parentName = parameters[1];
                var parentBirthday = parameters[2];

                var parent = new Person(parentName);
                parent.Birthday = parentBirthday;
                person.AddParent(parent);

                break;

            case "children":
                var childName = parameters[1];
                var childBirthday = parameters[2];

                var child = new Person(childName);
                child.Birthday = childBirthday;
                person.AddChild(child);

                break;

            case "car":
                var carModel = parameters[1];
                var carSpeed = int.Parse(parameters[2]);

                var car = new Car(carModel, carSpeed);
                person.Car = car;

                break;
        }
    }
}