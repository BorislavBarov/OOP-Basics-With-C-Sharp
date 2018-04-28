using System.Collections.Generic;

public interface IEatable
{
    IReadOnlyCollection<string> FavoriteFood { get; }

    double Calories { get; }

    string Eat(string foodType, int quantity);
}