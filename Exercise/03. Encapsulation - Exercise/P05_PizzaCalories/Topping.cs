using System;

public class Topping
{
    private const int MinWeight = 1;
    private const int MaxWeight = 50;

    private string type;
    private int weight;

    public Topping(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;
    }

    public string Type
    {
        get { return this.type; }
        private set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public int Weight
    {
        get { return this.weight; }
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            this.weight = value;
        }
    }
    
    private double GetTypeMod()
    {
        if (this.Type.ToLower() == "meat")
        {
            return 1.2;
        }
        else if (this.Type.ToLower() == "veggies")
        {
            return 0.8;
        }
        else if (this.Type.ToLower() == "cheese")
        {
            return 1.1;
        }

        return 0.9;
    }

    public double GetTotalCalories()
    {
        var result = 2 * Weight * this.GetTypeMod();
        return result;
    }
}