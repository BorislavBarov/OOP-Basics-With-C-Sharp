using System.Collections.Generic;
using System.Text;

public class Dog : Mammal, IDog
{
    private List<string> favoriteFoods = new List<string>() { "Meat" };

    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
        this.Calories = 0.40;
    }

    public override IReadOnlyCollection<string> FavoriteFood
    {
        get { return this.favoriteFoods; }
    }

    public override string Eat(string foodType, int quantity)
    {
        var sb = new StringBuilder();

        sb.AppendLine("Woof!")
          .AppendLine(base.Eat(foodType, quantity));

        return sb.ToString().TrimEnd();
    }
}