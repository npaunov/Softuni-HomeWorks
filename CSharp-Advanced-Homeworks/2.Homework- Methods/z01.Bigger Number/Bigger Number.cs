/*Write a method GetMax() with two parameters that returns the larger of two integers. Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);

    }
    static int GetMax(int first, int second)
    {
        int c = 0;
        if (first > second)
        {
            c = first;
        }
        else if (first < second)
        {
            c = second;
        }
        //c = Math.Max(first, second);
        return c;

    }
}

