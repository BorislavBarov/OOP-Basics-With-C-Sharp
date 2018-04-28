using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var trainers = new List<Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var trainerName = inputParts[0];
            var pokemonName = inputParts[1];
            var element = inputParts[2];
            var health = int.Parse(inputParts[3]);

            var pokemon = new Pokemon(pokemonName, element, health);

            if (!trainers.Any(t => t.Name == trainerName))
            {
                var trainer = new Trainer(trainerName);
                trainer.AddPokemon(pokemon);
                trainers.Add(trainer);
            }
            else
            {
                trainers.FirstOrDefault(t => t.Name == trainerName).AddPokemon(pokemon);
            }
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(x => x.Element == input))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                }
            }
        }

        trainers = trainers.OrderByDescending(t => t.Badges).ToList();

        foreach (var trainer in trainers)
        {
            Console.WriteLine(trainer.ToString());
        }
    }
}