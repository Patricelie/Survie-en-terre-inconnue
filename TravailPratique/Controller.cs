using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailPratique
{
    internal class Controller
    {
        public static void MainController()
        {
            while (true)
            {
                Console.Clear();
                Vue.DisplayGrid(Grid.grid, Grid.posY, Grid.posX);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.MoveUp();
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.MoveDown();
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.MoveLeft();
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.RightArrow:
                        Game.MoveRight();
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
