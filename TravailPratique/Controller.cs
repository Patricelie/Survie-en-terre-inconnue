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
                View.DisplayGrid(Game.grid, Game.posY, Game.posX);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.UpArrow:
                        Game.MoveUp();
                        View.GenerateColor('0');
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.DownArrow:
                        Game.MoveDown();
                        View.GenerateColor('0');
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.LeftArrow:
                        Game.MoveLeft();
                        View.GenerateColor('0');
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.RightArrow:
                        Game.MoveRight();
                        View.GenerateColor('0');
                        Game.PlaceBloc();
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }
    }
}
