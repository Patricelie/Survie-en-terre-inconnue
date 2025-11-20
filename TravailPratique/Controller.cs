using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TravailPratique
{
    internal class Controller
    {
        public static void MenuController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayMenu();
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        GameController();
                        break;
                    case "4":
                        break;
                    case "5":
                        return;
                }

            }
        }
        public static void GameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayGameMenu();
                View.DisplayGrid(Game.grid, Game.posY, Game.posX);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.MoveUp();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.MoveDown();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.MoveLeft();
                        break;
                    case ConsoleKey.RightArrow:
                        Game.MoveRight();
                        break;
                    case ConsoleKey.Spacebar:
                        Game.Collect(Game.grid);
                        break;
                    case ConsoleKey.Enter:
                        MenuGameController();
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }

        }
        public static void MenuGameController()
        {
            while (true)
            {
                Console.Clear();
                View.DisplayInventory();
                ConsoleKeyInfo touche = Console.ReadKey();
                if (touche.Key == ConsoleKey.Enter)
                {
                    GameController();
                }
            }
        }
    }
}
