﻿public abstract class Feline : Mammal, IFeline
{
    public Feline(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed { get; }

    public override string ToString()
    {
        var message = $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        return message;
    }
}
