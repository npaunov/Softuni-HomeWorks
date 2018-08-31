/*Write a method that returns the last digit of a given integer as an English word. Test the method with different input values. Ensure you name the method properly.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigit
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(n));
    }
    static string GetLastDigitAsWord(int n)
    {
        string[] numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int index = n % 10;
        return numbers[index];
    }

}

