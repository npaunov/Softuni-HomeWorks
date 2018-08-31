using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixShuffling
{
    static string[,] matrix;

    static void ElementsTurn(int x1, int y1, int x2, int y2)
    {
        string temp = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = temp;

        Print();
    }
    static void Print()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        matrix = new string[row, col];
        bool turn = false;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write("{0}{1} element: ", i,j);
                matrix[i, j] = Console.ReadLine();
            }
        }
        while (!turn)
        {
            string placeSwap = Console.ReadLine();
            if (placeSwap == "END")
            {
                turn = true;
                break;
            }
            string[] input = placeSwap.Split().ToArray();
            if (input[0] != "swap" && input.Length != 5)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int x1 = int.Parse(input[1]);
                int y1 = int.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);
                if ((x1 > row || x2 > row) || (y1 > col || y2 > col))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    ElementsTurn(x1, y1, x2, y2);
                }
            }
        }
    }
}
