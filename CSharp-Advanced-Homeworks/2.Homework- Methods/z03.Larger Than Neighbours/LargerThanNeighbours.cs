/*Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerThanNeighbours
{
    static void Main()
    {
        //int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }

    }
    static bool IsLargerThanNeighbours(int[] numArray, int n)
    {
        bool result = false;
        if (n == 0 || n == numArray.Length - 1)
        {
            result = numArray[Math.Abs(n - 1)] < numArray[n] ? true : false;
        }
        else if (numArray[n] > numArray[n - 1] && numArray[n] > numArray[n + 1])
        {
            result = true;
        }
        return result;
    }
}

