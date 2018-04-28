public abstract class Mammal : Animal, IMammal
{
    public Mammal(string name, double weight, string livingRegion)
        : base(name, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion { get; }

    public override string ToString()
    {
        var message = $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        return message;
    }
}