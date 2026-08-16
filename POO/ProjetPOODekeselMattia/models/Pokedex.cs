using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.Models
{
    public class Pokedex
    {
        public List<Pokemon> AllPokemons { get; private set; }

        public Pokedex()
        {
            AllPokemons = new List<Pokemon>();
        }

        public void Add(Pokemon p)
        {
            AllPokemons.Add(p);
        }

        public Pokemon? FindByName(string name)
        {
            return AllPokemons.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void PrintAll()
        {
            if (!AllPokemons.Any())
            {
                Console.WriteLine("Le Pokédex est vide.");
                return;
            }

            Console.WriteLine("Pokédex :");
            foreach (var p in AllPokemons)
                Console.WriteLine(" - " + p);
        }
    }
}
