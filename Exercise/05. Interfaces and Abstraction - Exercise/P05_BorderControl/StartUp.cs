using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inhabitants = new List<IInhabitant>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            var inhabitantInfo = inputLine.Split();

            if (inhabitantInfo.Length == 2)
            {
                var model = inhabitantInfo[0];
                var id = inhabitantInfo[1];
                var robot = new Robot(model, id);
                inhabitants.Add(robot);
            }
            else if (inhabitantInfo.Length == 3)
            {
                var name = inhabitantInfo[0];
                var age = int.Parse(inhabitantInfo[1]);
                var id = inhabitantInfo[2];
                var citizen = new Citizen(name, age, id);
                inhabitants.Add(citizen);
            }
        }

        var partOfFakeId = Console.ReadLine();

        var fakeIds = inhabitants.Select(i => i.Id).Where(i => i.EndsWith(partOfFakeId)).ToList();

        foreach (var id in fakeIds)
        {
            Console.WriteLine(id);
        }
    }
}