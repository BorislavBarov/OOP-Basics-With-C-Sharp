using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var choosenOne = Console.ReadLine();

        var inputLines = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            inputLines.Add(input);
        }

        var line = inputLines.SingleOrDefault(x => x.Contains(choosenOne) && !x.Contains("-"));
        var splitLine = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var name = $"{splitLine[0]} {splitLine[1]}";
        var birthdate = splitLine[2];

        var person = new Person();
        person.Name = name;
        person.Birthdate = birthdate;

        foreach (var inputLine in inputLines)
        {
            if (inputLine.Contains("-"))
            {
                splitLine = inputLine.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (splitLine[0] == name || splitLine[0] == birthdate)
                {
                    var child = new Person();

                    if (int.TryParse(splitLine[1][0].ToString(), out int num))
                    {
                        var childBirthdate = splitLine[1];
                        child = new Person();
                        child.Birthdate = childBirthdate;
                        person.AddChild(child);
                    }
                    else
                    {
                        var childName = splitLine[1];
                        child = new Person();
                        child.Name = childName;
                        person.AddChild(child);
                    }
                }
                else if (splitLine[1] == name || splitLine[1] == birthdate)
                {
                    var parent = new Person();

                    if (int.TryParse(splitLine[0][0].ToString(), out int num))
                    {
                        var parentBirthdate = splitLine[0];
                        parent = new Person();
                        parent.Birthdate = parentBirthdate;
                        person.AddParent(parent);
                    }
                    else
                    {
                        var parentName = splitLine[0];
                        parent = new Person();
                        parent.Name = parentName;
                        person.AddParent(parent);
                    }
                }
            }
        }

        foreach (var child in person.Children)
        {
            if (child.Name == null)
            {
                var currentLine = inputLines.FirstOrDefault(x => !x.Contains("-") && x.Contains(child.Birthdate));
                var splitCurrentLine = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentName = $"{splitCurrentLine[0]} {splitCurrentLine[1]}";
                child.Name = currentName;
            }
            else if (child.Birthdate == null)
            {
                var currentLine = inputLines.FirstOrDefault(x => !x.Contains("-") && x.Contains(child.Name));
                var splitCurrentLine = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentBirthdate = splitCurrentLine[2];
                child.Birthdate = currentBirthdate;
            }
        }

        foreach (var parent in person.Parents)
        {
            if (parent.Name == null)
            {
                var currentLine = inputLines.FirstOrDefault(x => !x.Contains("-") && x.Contains(parent.Birthdate));
                var splitCurrentLine = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentName = $"{splitCurrentLine[0]} {splitCurrentLine[1]}";
                parent.Name = currentName;
            }
            else if (parent.Birthdate == null)
            {
                var currentLine = inputLines.FirstOrDefault(x => !x.Contains("-") && x.Contains(parent.Name));
                var splitCurrentLine = currentLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentBirthdate = splitCurrentLine[2];
                parent.Birthdate = currentBirthdate;
            }
        }

        Console.WriteLine(person);
    }
}
