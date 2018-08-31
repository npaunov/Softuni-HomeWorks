using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("Rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Cols: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("row[{0}], col[{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        int lenght = 0;
        int longest = 0;
        string text = String.Empty;
        string allText = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if ((matrix[row, col].Equals(matrix[row, col + 1])) ||
                    (matrix[row, col].Equals(matrix[row + 1, col]))
                    || matrix[row, col].Equals(matrix[row + 1, col + 1]))
                {
                    text = matrix[row, col];
                    lenght++;

                    if (lenght > longest)
                    {
                        longest = lenght;
                        allText = text;
                    }
                }
            }
        }

        lenght = 1;
        text = String.Empty;

        for (int row = 0; row < n - 1; row++)
        {
            if (matrix[row, m - 1].Equals(matrix[row + 1, m - 1]))
            {
                text = matrix[row, m - 1];
                lenght++;

                if (lenght > longest)
                {
                    longest = lenght;
                    allText = text;
                }
            }
        }

        Console.WriteLine("Result: ");

        for (int i = 0; i < longest - 1; i++)
        {
            Console.Write("{0}, ", allText);
        }
        Console.WriteLine(allText);
    }
}

