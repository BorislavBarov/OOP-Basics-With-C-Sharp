using System;
using System.Globalization;

public class StartUp
{
    public static void Main()
    {
        var firstDate = Console.ReadLine();
        var secondDate = Console.ReadLine();

        var startDate = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        var dm = new DateModifier(startDate, endDate);

        var result = dm.CalculateDates();
        Console.WriteLine(result);
    }
}