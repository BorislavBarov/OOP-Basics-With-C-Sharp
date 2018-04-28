using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var calculator = new PriceCalculator();
        calculator.ParseCommand(input);
        calculator.CalcualteTotalPrice();
    }
}