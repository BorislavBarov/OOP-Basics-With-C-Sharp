using System.Collections.Generic;
using System.Text;

public class Cat : Feline, ICat
{
    private List<string> favoriteFoods = new List<string>() { "Vegetable", "Meat" };

    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
        this.Calories = 0.30;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("Meow")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}