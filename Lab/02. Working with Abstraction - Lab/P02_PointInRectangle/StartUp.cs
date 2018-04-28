using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Rectangle rectangle = new Rectangle(inputParts[0], inputParts[1], inputParts[2], inputParts[3]);

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var point = new Point(inputParts[0], inputParts[1]);
            Console.WriteLine(rectangle.Contains(point));
        }
    }
}