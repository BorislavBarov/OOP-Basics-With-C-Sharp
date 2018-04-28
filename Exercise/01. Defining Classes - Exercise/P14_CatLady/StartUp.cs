using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string line;
        var cats = new List<Cat>();

        while ((line = Console.ReadLine()) != "End")
        {
            var splitLine = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var breedOfCat = splitLine[0];
            var name = splitLine[1];
            Cat cat;

            switch (breedOfCat)
            {
                case "StreetExtraordinaire":
                    var decibelsOfMeows = int.Parse(splitLine[2]);
                    cat = new StreetExtraordinaire(name, decibelsOfMeows);
                    cats.Add(cat);
                    break;

                case "Siamese":
                    var earSize = int.Parse(splitLine[2]);
                    cat = new Siamese(name, earSize);
                    cats.Add(cat);
                    break;

                case "Cymric":
                    var furLength = double.Parse(splitLine[2]);
                    cat = new Cymric(name, furLength);
                    cats.Add(cat);
                    break;
            }
        }

        var inputName = Console.ReadLine();

        var choosenOne = cats.SingleOrDefault(c => c.Name == inputName);
        Console.WriteLine(choosenOne);
    }
}