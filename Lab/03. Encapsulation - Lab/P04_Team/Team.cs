﻿using System.Collections.Generic;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.Name = name;
        this.firstTeam = new List<Person>();
        this.reserveTeam = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public IReadOnlyCollection<Person> FirstTeam
    {
        get { return this.firstTeam; }
    }

    public IReadOnlyCollection<Person> ReserveTeam
    {
        get { return this.reserveTeam; }
    }

    public void AddPlayer(Person player)
    {
        if (player.Age < 40)
        {
            this.firstTeam.Add(player);
        }
        else
        {
            this.reserveTeam.Add(player);
        }
    }
}