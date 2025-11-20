using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravailPratique
{
    internal class Game
    {
        public const int MARAIS = 1;
        public const int FORET = 2;
        public const int MONTAGNE = 3;
        public const int RIVIERE = 4;
        public const int PRAIRIE = 5;
        public const int DESERT = 6;
        public static int countMarais = 0;
        public static int countForet = 0;
        public static int countMontagne = 0;
        public static int countRiviere = 0;
        public static int countPrairie = 0;
        public static int countDesert = 0;
        public static int[,] grid =
        {
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
        public static int posX = 0;
        public static int posY = 0;
        public static Random rnd = new Random();

        public static void DiscoverLand()
        {

            if (grid[posY, posX] == 0)
            {
                int number = rnd.Next(1, 7);
                grid[posY, posX] = number;
            }
            if(posY == 0 && posX == 0)
            {
                grid[posY, posX] = 0;
            }
        }

        public static void MoveUp()
        {
            if (posY > 0)
            {
                posY--;
                DiscoverLand();
            }
        }
        public static void MoveDown()
        {
           
            if (posY < grid.GetLength(0) - 1)
            {
                posY++;
                DiscoverLand();
            }
        }
        public static void MoveLeft()
        {
            
            if (posX > 0)
            {
                posX--;
                DiscoverLand();
            }
        }
        public static void MoveRight()
        {
            
            if (posX < grid.GetLength(0) - 1)
            {
                posX++;
                DiscoverLand();
            }
        }

        public static int Collect(int[,] grid)
        {
            switch(grid[posY, posX])
            {
                case MARAIS:
                    countMarais++;
                    return countMarais;
                case FORET:
                    countForet++;
                    return countForet;
                case PRAIRIE:
                    countPrairie++;
                    return countPrairie;
                case MONTAGNE:
                    countMontagne++;
                    return countMontagne;
                case RIVIERE:
                    countRiviere++;
                    return countRiviere;
                case DESERT:
                    countDesert++;
                    return countDesert;
                default: return 0;
            }
        }
    }
}
