using System;

public class StartUp
{
    public static void Main()
    {
        var input = Console.ReadLine();
        DrawingTool figure;

        if (input == "Square")
        {
            var size = int.Parse(Console.ReadLine());
            figure = new Square(size);
        }
        else
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            figure = new Rectangle(width, height);
        }

        figure.Draw();
    }
}