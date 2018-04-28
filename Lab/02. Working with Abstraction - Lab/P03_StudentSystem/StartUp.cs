using System;

public class StartUp
{
    public static void Main()
    {
        var studentSystem = new StudentSystem();

        string input;
        while ((input = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(input);
        }
    }
}