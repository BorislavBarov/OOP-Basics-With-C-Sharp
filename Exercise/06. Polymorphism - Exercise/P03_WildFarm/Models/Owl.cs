using System.Collections.Generic;
using System.Text;

public class Owl : Bird, IOwl
{
    private List<string> favoriteFoods = new List<string>() { "Meat" };

    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        this.Calories = 0.25;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("Hoot Hoot")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}