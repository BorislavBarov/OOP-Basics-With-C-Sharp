using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private const int MinLength = 1;
    private const int MaxLength = 15;
    private const int MinCount = 0;
    private const int MaxCount = 10;

    private string name;
    private List<Topping> topping;
    private Dough dough;

    public Pizza(string name, Dough dough)
    {
        this.Name = name;
        this.Dough = dough;
        this.topping = new List<Topping>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < MinLength || value.Length > MaxLength)
            {
                throw new ArgumentException($"{this.GetType().Name} name should be between {MinLength} and {MaxLength} symbols.");
            }

            this.name = value;
        }
    }

    public IReadOnlyCollection<Topping> Topping
    {
        get { return this.topping; }
    }

    public Dough Dough
    {
        get { return this.dough; }
        private set
        {
            this.dough = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        if (this.Topping.Count == MaxCount)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MinCount}..{MaxCount}].");
        }

        this.topping.Add(topping);
    }

    public double GetTotalCalories()
    {
        var totalToppingCalories = this.topping.Sum(t => t.GetTotalCalories());
        var result = totalToppingCalories + this.Dough.GetTotalCalories();

        return result;
    }
}