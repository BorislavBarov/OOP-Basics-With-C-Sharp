using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal, IMouse
{
    private List<string> favoriteFoods = new List<string>() { "Vegetable", "Fruit" };

    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
        this.Calories = 0.10;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("Squeak")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}