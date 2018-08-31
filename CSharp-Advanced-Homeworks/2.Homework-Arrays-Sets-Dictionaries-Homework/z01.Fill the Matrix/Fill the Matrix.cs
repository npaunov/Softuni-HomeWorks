using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FillTheMatrix
{
    static int numbers = 0;

    static void LeftMatrix()
    {
        int[,] left = new int[numbers, numbers];
        int counter = 1;
        for (int col = 0; col < numbers; col++)
        {
            for (int row = 0; row < numbers; row++)
            {
                left[row, col] = counter;
                counter++;
            }
        }
        Print(left);
    }
    static void RightMatrix()
    {
        int[,] right = new int[numbers, numbers];
        int counter = 1;
        for (int col = 0; col < numbers; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < numbers; row++)
                {
                    right[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = numbers - 1; row >= 0; row--)
                {
                    right[row, col] = counter;
                    counter++;
                }
            }
        }
        Print(right);
    }
    static void Print(int[,] theMatrix)
    {
        for (int a = 0; a < theMatrix.GetLength(0); a++)
        {
            for (int b = 0; b < theMatrix.GetLength(1); b++)
            {
                Console.Write("{0,4}", theMatrix[a, b]);
            }
            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        numbers = int.Parse(Console.ReadLine());
        Console.WriteLine("First: ");
        LeftMatrix();
        Console.WriteLine("Second: ");
        RightMatrix();
    }
}
