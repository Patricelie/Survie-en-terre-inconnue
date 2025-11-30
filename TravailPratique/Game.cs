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
        public static int countFeu = 0;
        public static int countHache = 0;
        public static int countVitre = 0;
        public static int countPlanche = 0;
        public static int countBrique = 0;
        public static int countIsolant = 0;
        public static int countMaison = 0;
        public static int countHiver = 560;
        public static int[,] saveGrid = new int[10, 10]; 
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
        public static void InitializeGame()
        {
            posX = 0;
            posY = 0;
            grid = new int[,]
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
            countMarais = 0;
            countForet = 0;
            countMontagne = 0;
            countRiviere = 0;
            countPrairie = 0;
            countDesert = 0;
            countFeu = 0;
            countHache = 0;
            countVitre = 0;
            countPlanche = 0;
            countBrique = 0;
            countIsolant = 0;
            countMaison = 0;
            countHiver = 560;
        }
        public static void DiscoverLand()
        {

            if (grid[posY, posX] == 0)
            {
                int number = rnd.Next(1, 7);
                grid[posY, posX] = number;
            }
            if (posY == 0 && posX == 0)
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

        public static void Collect()
        {
            switch (grid[posY, posX])
            {
                case MARAIS:
                    countMarais++;
                    return;
                case FORET:
                    countForet++;
                    return;
                case PRAIRIE:
                    countPrairie++;
                    return;
                case MONTAGNE:
                    countMontagne++;
                    return;
                case RIVIERE:
                    countRiviere++;
                    return;
                case DESERT:
                    countDesert++;
                    return;
            }
        }
        public static void Tools(ConsoleKeyInfo input)
        {
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    if (countForet >= 2 && countRiviere >= 1)
                    {
                        countFeu++;
                        countForet -= 2;
                        countRiviere--;
                    }
                    return;
                case ConsoleKey.D2:
                    if (countForet >= 1 && countMontagne >= 1)
                    {
                        countHache++;
                        countForet--;
                        countMontagne--;
                    }
                    return;
                case ConsoleKey.D3:
                    if (countDesert >= 5 && countFeu >= 1)
                    {
                        countVitre++;
                        countDesert -= 5;
                        countFeu--;
                    }
                    return;
                case ConsoleKey.D4:
                    if (countForet >= 4 && countHache >= 1)
                    {
                        countPlanche++;
                        countForet -= 4;
                        countHache--;
                    }
                    return;
                case ConsoleKey.D5:
                    if (countMarais >= 3 && countFeu >= 1)
                    {
                        countBrique++;
                        countMarais -= 3;
                        countFeu--;
                    }
                    return;
                case ConsoleKey.D6:
                    if (countPrairie >= 3)
                    {
                        countIsolant++;
                        countPrairie -= 3;
                    }
                    return;
                case ConsoleKey.D7:
                    if (countPlanche >= 4 && countBrique >= 4 && countIsolant >= 4 && countVitre >= 2)
                    {
                        countMaison++;
                        countPlanche -= 4;
                        countBrique -= 4;
                        countIsolant -= 4;
                        countVitre -= 2;
                    }
                    return;
            }
        }

        public static int WinterTimer()
        {
            return countHiver--;
        }
        public static bool IsGameWon()
        {
            return countMaison > 0;
        }

        public static void Backup()
        {
            int[] backupCounter = {posY,posX,countMarais,countPrairie,countRiviere,countMontagne,countForet,countDesert,countFeu,countBrique,countHache,countMaison,countIsolant,countPlanche,countVitre,countHiver};
            string counter = string.Join(",", backupCounter);
            File.WriteAllText("backup.text", $"{counter}\n");

            string[,] gridValues = new string[10, 10];
            for (int y = 0; y < grid.GetLength(0); y++)
            {
                for (int x = 0; x < grid.GetLength(1); x++)
                {
                    gridValues[y,x] = Convert.ToString(grid[y, x]);
                    File.AppendAllText("backup.text", $"{gridValues[y, x]},");
                }
                File.AppendAllText("backup.text", "\n");
            }
                    
        }

        public static void Backupfile()
        {
            string[] content = File.ReadAllLines("backup.text");

            string counter = content[0].Trim();
            string[] counterDivided = counter.Split(",");
            for (int j = 0; j < counterDivided.Length; j++)
            {
                posY = Convert.ToInt32(counterDivided[0]);
                posX = Convert.ToInt32(counterDivided[1]);
                countMarais = Convert.ToInt32(counterDivided[2]);
                countPrairie = Convert.ToInt32(counterDivided[3]);
                countRiviere = Convert.ToInt32(counterDivided[4]);
                countMontagne = Convert.ToInt32(counterDivided[5]);
                countForet = Convert.ToInt32(counterDivided[6]);
                countDesert = Convert.ToInt32(counterDivided[7]);
                countFeu = Convert.ToInt32(counterDivided[8]);
                countBrique = Convert.ToInt32(counterDivided[9]);
                countHache = Convert.ToInt32(counterDivided[10]);
                countMaison = Convert.ToInt32(counterDivided[11]);
                countIsolant = Convert.ToInt32(counterDivided[12]);
                countPlanche = Convert.ToInt32(counterDivided[13]);
                countVitre = Convert.ToInt32(counterDivided[14]);
                countHiver = Convert.ToInt32(counterDivided[15]);
            }

            for (int i = 1; i < content.Length; i++)
            {
                string ligne = content[i].Trim();
                string[] lignes = ligne.Split(",");
                for (int range = 0; range < 9; range++)
                {
                    for (int l = 0; l < lignes.Length; l++)
                    {
                        if (int.TryParse(lignes[l], out int nombre))
                        {
                            saveGrid[range, l] = Convert.ToInt32(lignes[l]);
                        }
                    }
                }
            }

        }
    }
}
