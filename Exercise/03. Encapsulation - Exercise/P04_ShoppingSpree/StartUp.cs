using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var firstInputLine = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        var secondInputLine = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        var people = new List<Person>();
        var products = new List<Product>();

        try
        {
            foreach (var part in firstInputLine)
            {
                var splitLine = part.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = splitLine[0];
                var money = decimal.Parse(splitLine[1]);

                var person = new Person(name, money);
                people.Add(person);
            }

            foreach (var part in secondInputLine)
            {
                var splitLine = part.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = splitLine[0];
                var cost = decimal.Parse(splitLine[1]);

                var product = new Product(name, cost);
                products.Add(product);
            }

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var splitLine = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var personName = splitLine[0];
                var productName = splitLine[1];

                var currentPerson = people.FirstOrDefault(p => p.Name == personName);
                var currentProduct = products.FirstOrDefault(p => p.Name == productName);

                try
                {
                    currentPerson.BuyProduct(currentProduct);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var person in people)
            {
                var result = person.BagOfProducts.Any() ? string.Join(", ", person.BagOfProducts.Select(x => x.Name).ToList()) : "Nothing bought";

                Console.WriteLine($"{person.Name} - {result}");
            }
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
        }
    }
}