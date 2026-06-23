using PokemonApp.Enums;

namespace PokemonApp.Models
{
    public class PlantePokemon : Pokemon
    {
        public PlantePokemon(string name, int level, int hp, int attack, int defense)
            : base(name, level, hp, attack, defense, PokemonType.Plante)
        {
        }

        public override int CalculateDamage()
        {
            return base.CalculateDamage() + 2;
        }
    }
}
