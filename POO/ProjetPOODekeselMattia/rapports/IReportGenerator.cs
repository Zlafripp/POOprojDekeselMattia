using PokemonApp.Models;

namespace PokemonApp.Reports
{
    public interface IReportGenerator
    {
        string Generate(Dresseur dresseur);
    }
}
