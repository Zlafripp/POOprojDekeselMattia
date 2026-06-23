using PokemonApp.Enums;

namespace PokemonApp.Models
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public PokemonType Type { get; set; }

        public Pokemon(string name, int level, int hp, int attack, int defense, PokemonType type)
        {
            Name = name;
            Level = level;
            HP = hp;
            Attack = attack;
            Defense = defense;
            Type = type;
        }

        public virtual int CalculateDamage()
        {
            return Attack + Level;
        }

        public override string ToString()
        {
            return $"{Name} (Lvl {Level}, {Type}, HP:{HP}, ATK:{Attack}, DEF:{Defense})";
        }
    }
}
