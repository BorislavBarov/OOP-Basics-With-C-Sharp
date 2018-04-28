using System;

public class StartUp
{
    public static void Main()
    {
        var numberOfInputLines = int.Parse(Console.ReadLine());
        var team = new Team("Manchester United");

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
                team.AddPlayer(person);
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
    }
}