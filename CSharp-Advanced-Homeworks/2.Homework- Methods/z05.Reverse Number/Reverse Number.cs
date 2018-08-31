/*Write a method that reverses the digits of a given floating-point number.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine(GetReversedNumber(double.Parse(Console.ReadLine())));
    }
    static double GetReversedNumber(double n)
    {
        double result = 0;
        if (n < 0)
        {
            result = double.Parse(string.Join("", n.ToString().TrimStart('-').Reverse()));
            result = -result;
            return result;            
        }
        else
        {
            result = double.Parse(string.Join("", n.ToString().Reverse()));
            return result;
        }
    }
}

