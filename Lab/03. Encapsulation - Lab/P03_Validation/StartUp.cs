using System;
using System.Collections.Generic;

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
            var salary = decimal.Parse(inputLine[3]);

            try
            {
                var person = new Person(firstName, lastName, age, salary);
                people.Add(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        var bonus = decimal.Parse(Console.ReadLine());

        people.ForEach(p => p.IncreaseSalary(bonus));
        people.ForEach(p => Console.WriteLine(p.ToString()));
    }
}