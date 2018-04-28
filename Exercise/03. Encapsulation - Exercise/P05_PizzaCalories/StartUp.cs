using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
            var firstInputLine = Console.ReadLine();
            var parts = firstInputLine.Split(new[] { ' ' }, StringSplitOptions.None);
            var name = parts[1];

            var secondInputLine = Console.ReadLine();
            parts = secondInputLine.Split(new[] { ' ' }, StringSplitOptions.None);
            var flourType = parts[1];
            var bakingTechnique = parts[2];
            var doughWeight = int.Parse(parts[3]);
            var dough = new Dough(flourType, bakingTechnique, doughWeight);
            var pizza = new Pizza(name, dough);

            string nextInputLine;
            while ((nextInputLine = Console.ReadLine()) != "END")
            {
                parts = nextInputLine.Split(new[] { ' ' }, StringSplitOptions.None);

                var type = parts[1];
                var toppingWeight = int.Parse(parts[2]);
                var topping = new Topping(type, toppingWeight);
                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}