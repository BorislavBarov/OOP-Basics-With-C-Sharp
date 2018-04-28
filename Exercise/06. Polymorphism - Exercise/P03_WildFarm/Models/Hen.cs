using System.Collections.Generic;
using System.Text;

public class Hen : Bird, IHen
{
    private List<string> favoriteFoods = new List<string>() { "Meat", "Vegetable", "Fruit", "Seeds" };

    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        this.Calories = 0.35;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("Cluck")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}