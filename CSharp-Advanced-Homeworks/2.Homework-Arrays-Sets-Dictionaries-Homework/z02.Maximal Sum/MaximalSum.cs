using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSum
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int allRows = input[0];
        int allCols = input[1];
        int[,] matrix = new int[allRows, allCols];
        int max = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = input[col];
            }
        }
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > max)
                {
                    max = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        Console.WriteLine("Sum = {0}", max);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
    }
}