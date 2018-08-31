/*Write a program to sort an array of numbers and then print them back on the console. The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UsingSelectionSort
{
    static void Main()
    {
        string arrString = Console.ReadLine();
        string[] items = arrString.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[items.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(items[i]);
        }

        for (int i = 0; i < numbers.Length; i++)
        {

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[i])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

