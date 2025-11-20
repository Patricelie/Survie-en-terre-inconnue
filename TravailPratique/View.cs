using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TravailPratique
{
    internal class View
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Menu Principal");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Jouer");
            Console.WriteLine("2. Charger une partie");
            Console.WriteLine("3. Sauvegarder une partie");
            Console.WriteLine("4. Crédits");
            Console.WriteLine("5. Quitter");
            Console.WriteLine("------------------------------------");
            Console.Write("Choisissez une option:");
        }
        public static void DisplayGameMenu()
        {
            Console.WriteLine("Jeu en cours...");
            Console.WriteLine($"Position du joueur:({Game.grid[Game.posY, Game.posX]}) - Terrain: {DisplayNameField(Game.grid)}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Apuyez sur Espace pour collecter des ressources.");
            Console.WriteLine("Apuyez sur Entrée pour ouvrir l'inventaire ou fabriquer des matériaux.");
            Console.WriteLine("Apuyez sur Esc pour revenir au menu principal.");
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void DisplayInventory()
        {
            Console.WriteLine("Inventaire du Joueur");
            Console.WriteLine("--------Ressources---------------");
            Console.WriteLine($"Fer:{Game.countMontagne}");
            Console.WriteLine($"Silex:{Game.countRiviere}");
            Console.WriteLine($"Bois:{Game.countForet}");
            Console.WriteLine($"Argile:{Game.countMarais}");
            Console.WriteLine($"Herbe:{Game.countPrairie}");
            Console.WriteLine($"Sable:{Game.countDesert}");
            Console.WriteLine("--------Outils---------------");
            Console.WriteLine($"Feu:{1}");
            Console.WriteLine($"Hache:{1}");
            Console.WriteLine($"Vitre:{1}");
            Console.WriteLine($"Planche:{1}");
            Console.WriteLine($"Brique:{1}");
            Console.WriteLine($"Isolant:{1}");
            Console.WriteLine($"Maison:{1}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Vous devez être à votre camp de base pour fabriquer des outils ou des matériaux.");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
        }
        public static void DisplayGrid(int[,] grid, int posY, int posX)
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    Console.BackgroundColor = GenerateColor(grid[y, x]);
                    if (y == posY && x == posX)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        public static ConsoleColor GenerateColor(int color)
        {

            switch (color)
            {
                case Game.MARAIS: return ConsoleColor.DarkBlue;
                case Game.FORET: return ConsoleColor.DarkGreen;
                case Game.DESERT: return ConsoleColor.Yellow;
                case Game.MONTAGNE: return ConsoleColor.Gray;
                case Game.RIVIERE: return ConsoleColor.Blue;
                case Game.PRAIRIE: return ConsoleColor.Green;
                default: return ConsoleColor.Black;
            }
        }

        public static String DisplayNameField(int[,] grid)
        {
            switch (Game.grid[Game.posY, Game.posX])
            {
                case Game.MARAIS:
                    return "Marais";
                case Game.FORET:
                    return "Foret";
                case Game.PRAIRIE:
                    return "Prairie";
                case Game.MONTAGNE:
                    return "Montagne";
                case Game.RIVIERE:
                    return "Riviere";
                case Game.DESERT:
                    return "Désert";
                default: return "Base";
            }
        }
    }
}
