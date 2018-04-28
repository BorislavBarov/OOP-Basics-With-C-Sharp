using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var soldiers = new List<ISoldier>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            var soldierInfo = inputLine.Split();

            var soldierType = soldierInfo[0];
            var id = int.Parse(soldierInfo[1]);
            var firstName = soldierInfo[2];
            var lastName = soldierInfo[3];
            var salary = double.Parse(soldierInfo[4]);

            ISoldier soldier = null;

            switch (soldierType)
            {
                case "Private":
                    soldier = new Private(id, firstName, lastName, salary);
                    break;
                case "LeutenantGeneral":
                    var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);

                    foreach (var privateSoldierId in soldierInfo.Skip(5))
                    {
                        var privateId = int.Parse(privateSoldierId);
                        ISoldier privateSoldier = soldiers.FirstOrDefault(s => s.Id == privateId);
                        leutenantGeneral.AddPrivate(privateSoldier);
                    }

                    soldier = leutenantGeneral;
                    break;
                case "Engineer":
                    var validEngineerCorps = Enum.TryParse(typeof(Corps), soldierInfo[5], out object engineerCorps);

                    if (!validEngineerCorps)
                    {
                        continue;
                    }

                    var engineer = new Engineer(id, firstName, lastName, salary, (Corps)engineerCorps);

                    for (int i = 6; i < soldierInfo.Length; i += 2)
                    {
                        var partName = soldierInfo[i];
                        var hoursWorked = int.Parse(soldierInfo[i + 1]);
                        var repair = new Repair(partName, hoursWorked);
                        engineer.AddRepair(repair);
                    }

                    soldier = engineer;
                    break;
                case "Commando":
                    var validCommandoCorps = Enum.TryParse(typeof(Corps), soldierInfo[5], out object commandoCorps);

                    if (!validCommandoCorps)
                    {
                        continue;
                    }

                    var commando = new Commando(id, firstName, lastName, salary, (Corps)commandoCorps);

                    for (int i = 6; i < soldierInfo.Length; i += 2)
                    {
                        var codeName = soldierInfo[i];
                        var validMissionState = Enum.TryParse(typeof(State), soldierInfo[i + 1], out object missionState);

                        if (!validMissionState)
                        {
                            continue;
                        }

                        var mission = new Mission(codeName, (State)missionState);
                        commando.AddMission(mission);
                    }

                    soldier = commando;
                    break;
                case "Spy":
                    var codeNumber = int.Parse(soldierInfo[4]);
                    soldier = new Spy(id, firstName, lastName, codeNumber);
                    break;
            }

            soldiers.Add(soldier);
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }
}