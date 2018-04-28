using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var box = new Box(length, width, height);

            var surfaceArea = box.CalculateSurfaceArea(box);
            var lateralSurfaceArea = box.CalculateLateralSurfaceArea(box);
            var volume = box.CalculateVolume(box);

            Console.WriteLine($"Surface Area - {surfaceArea:f2}");
            Console.WriteLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            Console.WriteLine($"Volume - {volume:f2}");
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}