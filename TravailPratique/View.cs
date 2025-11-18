using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string option = Console.ReadLine();
        }
        public static void DisplayGrid(char[,] grid, int posY, int posX)
        {
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    if (y == posY && x == posX)
                    {
                        Console.WriteLine('X');
                    }
                    else
                    {
                        Console.Write(grid[y, x]);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void GenerateColor()
        {
    
            if( color == 0)
            {
                Console.BackgroundColor = ConsoleColor.Green/*Foret*/;
            }
            else if( color == 1) {
                Console.BackgroundColor = ConsoleColor.Blue/*Riviere*/;
            }
    }
}
