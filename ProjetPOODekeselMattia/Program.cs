using System;
using PokemonApp.Enums;
using PokemonApp.Models;
using PokemonApp.Reports;

namespace PokemonApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Pokedex();
            Console.Write("Entre le nom de ton dresseur : ");
            string nomDresseur = Console.ReadLine();
            var dresseur = new Dresseur(nomDresseur);


            pokedex.Add(new FeuPokemon("Salamèche", 5, 20, 8, 3));
            pokedex.Add(new EauPokemon("Carapuce", 5, 22, 6, 5));
            pokedex.Add(new PlantePokemon("Bulbizarre", 5, 21, 7, 4));


            bool run = true;

            while (run)
            {
                Console.WriteLine("\n1. Voir Pokédex");
                Console.WriteLine("2. Ajouter à l'équipe");
                Console.WriteLine("3. Voir équipe");
                Console.WriteLine("4. Combat");
                Console.WriteLine("5. Rapport stats");
                Console.WriteLine("6. Rapport plus fort");
                Console.WriteLine("0. Quitter");

                Console.Write("Choix : ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        pokedex.PrintAll();
                        break;

                    case "2":
                        Console.Write("Nom du Pokémon : ");
                        var name = Console.ReadLine();
                        var p = pokedex.FindByName(name);
                        if (p != null) dresseur.AddPokemon(p);
                        break;

                    case "3":
                        dresseur.PrintTeam();
                        break;

                    case "4":
                        Console.Write("P1 : ");
                        var n1 = Console.ReadLine();
                        Console.Write("P2 : ");
                        var n2 = Console.ReadLine();

                        var p1 = dresseur.GetPokemon(n1);
                        var p2 = dresseur.GetPokemon(n2);

                        if (p1 != null && p2 != null)
                            new Combat(p1, p2).Start();
                        break;

                    case "5":
                        Console.WriteLine(new ReportService(new StatEquipeReport()).Generate(dresseur));
                        break;

                    case "6":
                        Console.WriteLine(new ReportService(new PlusFortPokemon()).Generate(dresseur));
                        break;

                    case "0":
                        run = false;
                        break;
                }
            }
        }
    }
}
