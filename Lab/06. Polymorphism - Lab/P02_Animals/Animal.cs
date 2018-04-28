public class Animal
{
    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }

    public string Name { get; }

    public string FavouriteFood { get; }

    public virtual string ExplainSelf()
    {
        var message = $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        return message;
    }
}