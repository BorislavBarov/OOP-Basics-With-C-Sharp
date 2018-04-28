public abstract class Bird : Animal, IBird
{
    public Bird(string name, double weight, double wingSize)
        : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize { get; }

    public override string ToString()
    {
        var message = $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        return message;
    }
}