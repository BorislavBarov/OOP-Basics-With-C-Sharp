using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var gandalf = new Gandalf();

        foreach (var str in input)
        {
            var food = FoodFactory.ProduceFood(str);
            gandalf.Eat(food);
        }

        Console.WriteLine(gandalf);
    }
}