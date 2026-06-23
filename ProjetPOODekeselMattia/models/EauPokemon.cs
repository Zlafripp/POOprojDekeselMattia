using PokemonApp.Enums;

namespace PokemonApp.Models
{
    public class EauPokemon : Pokemon
    {
        public EauPokemon(string name, int level, int hp, int attack, int defense)
            : base(name, level, hp, attack, defense, PokemonType.Eau)
        {
        }

        public override int CalculateDamage()
        {
            return base.CalculateDamage() + 3;
        }
    }
}
