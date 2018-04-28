using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfLines = int.Parse(Console.ReadLine());
        var buyers = new List<IBuyer>();

        for (int i = 0; i < numberOfLines; i++)
        {
            var inhabitantInfo = Console.ReadLine().Split();

            if (inhabitantInfo.Length == 3)
            {
                var rebelName = inhabitantInfo[0];
                var rebelAge = int.Parse(inhabitantInfo[1]);
                var rebelGroup = inhabitantInfo[2];
                var rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                buyers.Add(rebel);
            }
            else if (inhabitantInfo.Length == 4)
            {
                var citizenName = inhabitantInfo[0];
                var citizenAge = int.Parse(inhabitantInfo[1]);
                var citizenId = inhabitantInfo[2];
                var citizenBirthdate = DateTime.ParseExact(inhabitantInfo[3], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                var citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate);
                buyers.Add(citizen);
            }
        }

        string name;
        while ((name = Console.ReadLine()) != "End")
        {
            var buyer = buyers.FirstOrDefault(b => b.Name == name);

            if (buyer != null)
            {
                buyer.BuyFood();
            }
        }

        var amount = buyers.Sum(b => b.Food);
        Console.WriteLine(amount);
    }
}