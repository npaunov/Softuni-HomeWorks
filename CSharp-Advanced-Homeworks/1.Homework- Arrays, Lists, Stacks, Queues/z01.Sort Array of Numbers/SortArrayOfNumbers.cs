/*Write a program to read an array of numbers from the console, sort them and print them back on the console. The numbers should be entered from the console on a single line, separated by a space. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbers
{
    static void Main()
    {

        string arrString = Console.ReadLine();
        //string[] items = arrString.Split(' ');
        string[] items = arrString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int[] numbers = new int[items.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(items[i]);
        }

        bool turn = true;

        while (turn)
        {
            turn = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    int promenliva = 0;
                    promenliva = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = promenliva;
                    turn = true;
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

