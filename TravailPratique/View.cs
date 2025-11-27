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
            Console.WriteLine($"Jeu en cours...Il vous reste {Game.countHiver} actions avant l'hivers");
            Console.WriteLine($"Position du joueur: {(Game.posY, Game.posX)} - Terrain: {DisplayNameField(Game.grid)}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Utilisez les flèches pour vous déplacer.");
            Console.WriteLine("Apuyez sur Espace pour collecter des ressources.");
            Console.WriteLine("Apuyez sur Entrée pour ouvrir l'inventaire ou fabriquer des matériaux.");
            Console.WriteLine("Apuyez sur Esc pour revenir au menu principal.");
            Console.WriteLine("--------------------------------------------------------");
        }
        public static void DisplayCredits()
        {
            Console.WriteLine("Crédits");
            Console.WriteLine("---------");
            Console.WriteLine("Développé par:");
            Console.WriteLine("-Patricelie Njoh Ngueng");
            Console.WriteLine("-Aminata Diao");
            Console.WriteLine("Nos améliorations");
            Console.WriteLine("1. Un chronomètre annonçant l’arrivé de l’hiver.");
            Console.WriteLine("2. Du Ascii Art représentant les tuiles");
            Console.WriteLine("Apuyez sur une touche pour continuer.");
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
            Console.WriteLine($"Feu:{Game.countFeu}");
            Console.WriteLine($"Hache:{Game.countHache}");
            Console.WriteLine($"Vitre:{Game.countVitre}");
            Console.WriteLine($"Planche:{Game.countPlanche}");
            Console.WriteLine($"Brique:{Game.countBrique}");
            Console.WriteLine($"Isolant:{Game.countIsolant}");
            Console.WriteLine($"Maison:{Game.countMaison}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Vous devez être à votre camp de base pour fabriquer des outils ou des matériaux.");
            Console.WriteLine("Appuyez sur Entrer pour continuer...");
        }
        public static void DisplayMaterial()
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
            Console.WriteLine($"Feu:{Game.countFeu}");
            Console.WriteLine($"Hache:{Game.countHache}");
            Console.WriteLine($"Vitre:{Game.countVitre}");
            Console.WriteLine($"Planche:{Game.countPlanche}");
            Console.WriteLine($"Brique:{Game.countBrique}");
            Console.WriteLine($"Isolant:{Game.countIsolant}");
            Console.WriteLine($"Maison:{Game.countMaison}");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Feu: 2 Bois, 1 Silex");
            Console.WriteLine("2. Hache: 1 Bois, 1 Fer");
            Console.WriteLine("3. Vitre: 5 Sable, 1 Feu");
            Console.WriteLine("4. Planche: 4 Bois, 1 Hache");
            Console.WriteLine("5. Brique: 3 Argile, 1 Feu");
            Console.WriteLine("6. Isolant: 3 Herbe");
            Console.WriteLine("7. Maison: 4 Planche, 4 Brique, 4 Isolant, 2 Vitre");
            Console.WriteLine("Choisissez un objet à fabriquer (ou appuyez sur Entrée pour annuler):");
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
                        Console.Write(")(");
                    }
                    else
                    {
                        Console.Write("  ");
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
                    return "Marais \n ^  ^  ^   ^         \r\n/|\\/|\\/|\\ /|\\      \r\n/|\\/|\\/|\\ /|\\      \r\n/|\\/|\\/|\\ /|\\ \r\n^\"~-,._.,-~\"^\"~-,._\\/,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._";
                case Game.FORET:
                    return "Foret \n ^  ^   ^  ^  ^   ^  ^\r\n/|\\/|\\ /|\\/|\\/|\\ /|\\/|\\\r\n/|\\/|\\ /|\\/|\\/|\\ /|\\/|\\\r\n/|\\/|\\ /|\\/|\\/|\\ /|\\/|\\";
                case Game.PRAIRIE:
                    return "Prairie \n                     _\r\n                  _(_)_                          wWWWw   _\r\n      @@@@       (_)@(_)   vVVVv     _     @@@@  (___) _(_)_\r\n     @@()@@ wWWWw  (_)\\    (___)   _(_)_  @@()@@   Y  (_)@(_)\r\n      @@@@  (___)     `|/    Y    (_)@(_)  @@@@   \\|/   (_)\\\r\n       /      Y       \\|    \\|/    /(_)    \\|      |/      |\r\n    \\ |     \\ |/       | / \\ | /  \\|/       |/    \\|      \\|/\r\njgs \\\\|//   \\\\|///  \\\\\\|//\\\\\\|/// \\|///  \\\\\\|//  \\\\|//  \\\\\\|// \r\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
                case Game.MONTAGNE:
                    return "Montagne \n           ,                  /\\.__      _.-\\\r\n          /~\\,      __       /~    \\   ./    \\\r\n        ,/  /_\\   _/  \\    ,/~,_.~'\"\\ /_\\_  /'\\\r\n       / \\ /## \\ / V#\\/\\  /~8#  # ## V8  #\\/8 8\\\r\n     /~#'#\"#\"\"##V&#&# ##\\/88#\"#8# #\" #\\#&\"##\" ##\\\r\n    j# ##### #\"#\\&&\"####/###&  #\"#&## #&\" #\"#&#\"#'\\\r\n   /#\"#\"#####\"###'\\&##\"/&#\"####\"### # #&#&##\"#\"### \\\r\n  J#\"###\"#\"#\"#\"####'\\# #\"##\"#\"##\"#\"#####&\"## \"#\"&\"##|\\";
                case Game.RIVIERE:
                    return "Riviere \n ^\"~-,._.,-~\"^\"~-,._\\/,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._\r\n~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._.,-~\"^\"~-,._";
                case Game.DESERT:
                    return "Désert \n          || |                               \r\n          || |   ,                          \r\n          || |  | |\r\n          || '--' |\r\n    ,,    || .----'\r\n   || |   || |\r\n   |  '---'| |\r\n   '------.| |                                  _____\r\n   ((_))  || |      (  _                       / /|\\ \\\r\n   (o o)  || |      ))(\"),                    | | | | |\r\n____\\_/___||_|_____((__^_))____________________\\_\\|/_/__";
                default: return "Base \n  .-------------------.              ___\r\n(   I had a crash!    )            /  /]\r\n `-------------.   ,-'            /  / ]\r\n                \\ |      _____,. '  /__]\r\n             )   \\|   ,-'             _>\r\n               (  ` _/  AVION    ,. '`\r\n              )    / |     _,. '`\r\n              (   /. /    |\r\n               ) ,  /`  ./\r\n              (  \\_/   //_ _\r\n               ) /    //  (_)\r\n             _,~'#   (/.\r\n~~~~~~~~~~~~~~~#~~#~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            }
        }

        public static void EndGame()
        {
            Console.WriteLine("Merci d'avoir joué");
        }

        public static void Succeed()
        {
            Console.Clear();
            Console.WriteLine("  ___I_\r\n /\\-_--\\\r\n/  \\_-__\\\r\n|[]| [] |");
            Console.WriteLine("Vous avez réussi à construire votre maison");
            Console.ReadKey();
        }
        public static void DisplayGameOver()
        {
            Console.Clear();
            Console.WriteLine("Vous avez perdu le jeu car l'hiver est arrivé");
            Console.ReadKey();
        }
    }
}
