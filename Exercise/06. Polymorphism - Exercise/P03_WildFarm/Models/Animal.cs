using System.Collections.Generic;
using System.Linq;

public abstract class Animal : IAnimal
{
    private int foodEaten;
    
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = foodEaten;
    }

    public string Name { get; }

    public double Weight { get; set; }

    public int FoodEaten
    {
        get { return this.foodEaten; }
        set { this.foodEaten = value; }
    }

    public virtual IReadOnlyCollection<string> FavoriteFood { get; }

    public double Calories { get; set; }

    public virtual string Eat(string foodType, int quantity)
    {
        if (!this.FavoriteFood.Contains(foodType))
        {
            var message = $"{this.GetType().Name} does not eat {foodType}!";
            return message;
        }

        this.Weight += (quantity * this.Calories);
        this.FoodEaten += quantity;
        return string.Empty;
    }
}