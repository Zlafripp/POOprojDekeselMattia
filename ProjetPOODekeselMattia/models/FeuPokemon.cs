using PokemonApp.Enums;

namespace PokemonApp.Models
{
    public class FeuPokemon : Pokemon
    {
        public FeuPokemon(string name, int level, int hp, int attack, int defense)
            : base(name, level, hp, attack, defense, PokemonType.Feu)
        {
        }

        public override int CalculateDamage()
        {
            return base.CalculateDamage() + 5;
        }
    }
}
