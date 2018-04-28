using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var teams = new List<Team>();

        string inputline;
        while ((inputline = Console.ReadLine()) != "END")
        {
            try
            {
                var splitInputLine = inputline.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                var command = splitInputLine[0];
                var teamName = string.Empty;
                var playerName = string.Empty;

                switch (command)
                {
                    case "Team":
                        teamName = splitInputLine[1];
                        var team = new Team(teamName);
                        teams.Add(team);
                        break;

                    case "Add":
                        teamName = splitInputLine[1];
                        var currentTeam = teams.FirstOrDefault(t => t.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                        playerName = splitInputLine[2];
                        var endurance = int.Parse(splitInputLine[3]);
                        var sprint = int.Parse(splitInputLine[4]);
                        var dribble = int.Parse(splitInputLine[5]);
                        var passing = int.Parse(splitInputLine[6]);
                        var shooting = int.Parse(splitInputLine[7]);
                        var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        currentTeam.AddPlayer(player);
                        break;

                    case "Remove":
                        teamName = splitInputLine[1];
                        playerName = splitInputLine[2];
                        var currTeam = teams.FirstOrDefault(t => t.Name == teamName);
                        var currentPlayer = currTeam.Players.FirstOrDefault(p => p.Name == playerName);

                        if (currentPlayer == null)
                        {
                            throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
                        }

                        currTeam.RemovePlayer(currentPlayer);
                        break;

                    case "Rating":
                        teamName = splitInputLine[1];
                        var cTeam = teams.FirstOrDefault(t => t.Name == teamName);

                        if (cTeam == null)
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }

                        Console.WriteLine($"{teamName} - {cTeam.GetRating()}");
                        break;
                }
            }
            catch (ArgumentException argEx)
            {
                Console.WriteLine(argEx.Message);
            }
        }
    }
}