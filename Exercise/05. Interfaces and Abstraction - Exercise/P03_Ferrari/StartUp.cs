using System;

public class StartUp
{
    public static void Main()
    {
        var driverName = Console.ReadLine();
        ICar car = new Ferrari(driverName);
        Console.WriteLine(car);
    }
}