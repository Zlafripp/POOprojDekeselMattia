using PokemonApp.Models;
namespace PokemonApp.Reports
{
    public class ReportService
    {
        private IReportGenerator _strategy;

        public ReportService(IReportGenerator strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IReportGenerator strategy)
        {
            _strategy = strategy;
        }

        public string Generate(Dresseur dresseur)
        {
            return _strategy.Generate(dresseur);
        }
    }
}
