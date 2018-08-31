namespace _05PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;

    class PathsBetweenCells
    {
        // private static char[,] matrix =
        //    {
        //        { 's', ' ', ' ', ' ' },
        //        { ' ', '*', '*', ' ' },
        //        { ' ', '*', '*', ' ' },
        //        { ' ', '*', 'e', ' ' },
        //        { ' ', ' ', ' ', ' ' }
        //    };
        private static char[,] matrix =
            {
                { 's', ' ', ' ', ' ', '*' },
                { ' ', ' ', '*', ' ', '*' },
                { '*', ' ', '*', ' ', ' ' },
                { '*', ' ', '*', 'e', ' ' },
                { ' ', ' ', ' ', ' ', ' ' }
        };

        private static int numberOfPaths;

        private static List<char> path = new List<char>();

        static void Main()
        {
            FindPaths();
            Console.WriteLine("Total paths found: {0}", numberOfPaths);
        }

        private static void FindPaths(int row = 0, int col = 0, char symbol = 's')
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return;
            }
            if (matrix[row, col] == 'x' || matrix[row, col] == '*')
            {
                return;
            }

            path.Add(symbol);

            if (matrix[row, col] == 'e')
            {
                if (path[0] == 's')
                {
                    path.RemoveAt(0);
                }
                PrintPath();
                numberOfPaths++;
                path.RemoveAt(path.Count - 1);
                return;
            }

            matrix[row, col] = 'x';

            FindPaths(row, col + 1, 'R');
            FindPaths(row, col - 1, 'L');
            FindPaths(row + 1, col, 'D');
            FindPaths(row - 1, col, 'U');

            matrix[row, col] = ' ';

            if (path.Count != 0)
            {
                path.RemoveAt(path.Count - 1);
            }

        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join(string.Empty, path));
        }
    }
}
