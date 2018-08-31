using System;
using System.Text;

class CollecttheCoins
{
    static void Main(string[] args)
    {
        
        string[] matrix = new string[4];
        int row = 0;
        for (row = 0; row < 4; row++)
        {
            matrix[row] = Console.ReadLine();
        }
        string comand = Console.ReadLine();
        row = 0;
        int col = 0;
        int coins = 0;
        int hitWalls = 0;
        bool direction = true;
        for (int i = 0; i < comand.Length; i++)
        {
            if (matrix[row][col] == '$' && direction)
            {
                coins++;
            }
            if (comand[i] == '>' && col + 1 <= matrix[row].Length)
            {
                col++;
                direction = true;
            }
            else if (comand[i] == '<' && col - 1 >= 0)
            {
                col--;
                direction = true;
            }
            else if (comand[i] == '^' && row - 1 >= 0 && matrix[row - 1].Length > col)
            {
                row--;
                direction = true;
            }
            else if (comand[i] == 'V' && row + 1 < matrix.Length && matrix[row + 1].Length > col)
            {
                row++;
                direction = true;
            }
            else
            {
                hitWalls++;
                direction = false;
            }
        }
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", hitWalls);
    }
}