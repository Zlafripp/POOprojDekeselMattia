using System.Linq;
using PokemonApp.Models;

namespace PokemonApp.Reports
{
    public class StatEquipeReport : IReportGenerator
    {
        public string Generate(Dresseur dresseur)
        {
            if (!dresseur.Team.Any())
                return "L'équipe est vide.";

            double avg = dresseur.Team.Average(p => p.Level);
            int totalHp = dresseur.Team.Sum(p => p.HP);

            return $"Stats : Niveau moyen = {avg:F1}, HP total = {totalHp}";
        }
    }
}
