namespace _06ConnectedAreasInAMatrix
{
    using System;
    using System.Collections.Generic;

    class ConnectedAreasMain
    {
        private static SortedSet<ComparingArea> areasContainer = new SortedSet<ComparingArea>();
        private static int areaSize = 0;

        private static char[,] labirynth =
            {
                { '*', ' ', '*', ' ', ' ', '*', ' ', ' ', ' ' },
                { '*', ' ', '*', ' ', ' ', '*', ' ', ' ', ' ' },
                { '*', ' ', '*', ' ', ' ', '*', ' ', ' ', ' ' },
                { '*', ' ', '*', '*', '*', '*', '*', '*', '*' },
                { '*', ' ', '*', ' ', ' ', ' ', ' ', ' ', '*' }
            };
        static void Main()
        {
            ProcessArea();
            PrintAllAreas();
        }
        
        private static void ProcessArea()
        {
            for (int row = 0; row < labirynth.GetLength(0); row++)
            {
                for (int col = 0; col < labirynth.GetLength(1); col++)
                {
                    if (labirynth[row, col] == ' ')
                    {
                        Traverse(row, col);
                        areasContainer.Add(new ComparingArea(areaSize, row, col));
                        areaSize = 0;
                    }
                }
            }
        }

        private static void Traverse(int row, int col)
        {
            if (row < 0 || col < 0 || row >= labirynth.GetLength(0) || col >= labirynth.GetLength(1))
            {
                return;
            }

            if (labirynth[row, col] == 'x' || labirynth[row, col] == '*')
            {
                return;
            }

            areaSize++;
            labirynth[row, col] = 'x';

            Traverse(row + 1, col);
            Traverse(row - 1, col);
            Traverse(row, col + 1);
            Traverse(row, col - 1);
        }

        private static void PrintAllAreas()
        {
            if (areasContainer.Count == 0)
            {
                Console.WriteLine("No Areas!");
            }
            else
            {
                int count = 0;
                foreach (var area in areasContainer)
                {
                    count++;
                    Console.WriteLine("Area #{0} at {1}", count, area);
                }
            }
        }
    }
}
