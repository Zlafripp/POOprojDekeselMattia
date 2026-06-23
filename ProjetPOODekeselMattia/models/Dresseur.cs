using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonApp.Models
{
    public class Dresseur
    {
        public string Name { get; set; }
        public List<Pokemon> Team { get; private set; }

        public Dresseur(string name)
        {
            Name = name;
            Team = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon p)
        {
            if (Team.Count >= 6)
            {
                Console.WriteLine("L'équipe est pleine.");
                return;
            }

            Team.Add(p);
        }

        public Pokemon? GetPokemon(string name)
        {
            return Team.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void PrintTeam()
        {
            if (!Team.Any())
            {
                Console.WriteLine("L'équipe est vide.");
                return;
            }

            Console.WriteLine($"Équipe de {Name} :");
            foreach (var p in Team)
                Console.WriteLine(" - " + p);
        }
    }
}
