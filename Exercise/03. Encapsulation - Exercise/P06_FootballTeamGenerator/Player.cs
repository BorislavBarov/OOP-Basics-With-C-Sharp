using System;

public class Player
{
    private const int MinStatValue = 0;
    private const int MaxStatValue = 100;

    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    public int Endurance
    {
        get { return this.endurance; }
        private set
        {
            ValidateStat(value, nameof(this.Endurance));

            this.endurance = value;
        }
    }

    public int Sprint
    {
        get { return this.sprint; }
        private set
        {
            ValidateStat(value, nameof(this.Sprint));

            this.sprint = value;
        }
    }

    public int Dribble
    {
        get { return this.dribble; }
        private set
        {
            ValidateStat(value, nameof(this.Dribble));

            this.dribble = value;
        }
    }

    public int Passing
    {
        get { return this.passing; }
        private set
        {
            ValidateStat(value, nameof(this.Passing));

            this.passing = value;
        }
    }

    public int Shooting
    {
        get { return this.shooting; }
        private set
        {
            ValidateStat(value, nameof(this.Shooting));

            this.shooting = value;
        }
    }

    public int GetRating()
    {
        var result = (int)Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Shooting + this.Passing) / 5d);
        return result;
    }

    private static void ValidateStat(int statValue, string statName)
    {
        if (statValue < MinStatValue || statValue > MaxStatValue)
        {
            throw new ArgumentException($"{statName} should be between {MinStatValue} and {MaxStatValue}.");
        }
    }
}