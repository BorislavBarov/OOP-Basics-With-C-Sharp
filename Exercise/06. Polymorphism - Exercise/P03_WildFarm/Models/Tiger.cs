using System.Collections.Generic;
using System.Text;

public class Tiger : Feline, ITiger
{
    private List<string> favoriteFoods = new List<string>() { "Meat" };

    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
        this.Calories = 1.00;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("ROAR!!!")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}