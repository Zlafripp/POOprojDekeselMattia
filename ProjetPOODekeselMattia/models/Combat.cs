using System;

namespace PokemonApp.Models
{
    public class Combat
    {
        public Pokemon P1 { get; }
        public Pokemon P2 { get; }

        public Combat(Pokemon p1, Pokemon p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public Pokemon Start()
        {
            Console.WriteLine($"Combat entre {P1.Name} et {P2.Name} !");
            int hp1 = P1.HP;
            int hp2 = P2.HP;

            bool turn = true;

            while (hp1 > 0 && hp2 > 0)
            {
                if (turn)
                {
                    int dmg = Math.Max(1, P1.CalculateDamage() - P2.Defense);
                    hp2 -= dmg;
                    Console.WriteLine($"{P1.Name} inflige {dmg} dégâts.");
                }
                else
                {
                    int dmg = Math.Max(1, P2.CalculateDamage() - P1.Defense);
                    hp1 -= dmg;
                    Console.WriteLine($"{P2.Name} inflige {dmg} dégâts.");
                }

                turn = !turn;
            }

            Pokemon winner = hp1 > 0 ? P1 : P2;
            Console.WriteLine($"Vainqueur : {winner.Name}");
            return winner;
        }
    }
}
