using System;

public class Dough
{
    private const string ErrorMessage = "Invalid type of dough.";
    private const int MinWeight = 1;
    private const int MaxWeight = 200;

    private string flourType;
    private string bakingTechnique;
    private int weight;

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get { return this.flourType; }
        private set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException(ErrorMessage);
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException(ErrorMessage);
            }

            this.bakingTechnique = value;
        }
    }

    public int Weight
    {
        get { return this.weight; }
        private set
        {
            if (value < MinWeight || value > MaxWeight)
            {
                throw new ArgumentException($"{this.GetType().Name} weight should be in the range [{MinWeight}..{MaxWeight}].");
            }

            this.weight = value;
        }
    }

    private double GetTypeMod()
    {
        if (this.FlourType.ToLower() == "white")
        {
            return 1.5;
        }

        return 1;
    }

    private double GetTechMod()
    {
        if (this.BakingTechnique.ToLower() == "crispy")
        {
            return 0.9;
        }
        else if (this.BakingTechnique.ToLower() == "chewy")
        {
            return 1.1;
        }

        return 1;
    }

    public double GetTotalCalories()
    {
        var result = (2 * this.Weight) * GetTypeMod() * GetTechMod();
        return result;
    }
}