using System.Linq;
using PokemonApp.Models;

namespace PokemonApp.Reports
{
    public class PlusFortPokemon : IReportGenerator
    {
        public string Generate(Dresseur dresseur)
        {
            if (!dresseur.Team.Any())
                return "L'équipe est vide.";

            var strongest = dresseur.Team.OrderByDescending(p => p.Attack + p.Level).First();

            return $"Pokémon le plus fort : {strongest.Name}";
        }
    }
}
