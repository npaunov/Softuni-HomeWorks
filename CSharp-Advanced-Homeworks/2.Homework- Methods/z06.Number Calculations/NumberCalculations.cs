/*Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. Overload the methods to work with numbers of type int and double.
Note: Do not use LINQ.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Linq;


class NumberCalculations
{
    static void Main()
    {
        Console.WriteLine("Enter Doubles:");
        double[] doubles = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
        Console.WriteLine("Doubles: Min:{0}, Max:{1}, Avarage:{2}, Sum;{3}, Product:{4}", Min(doubles), Max(doubles), Avarage(doubles), Sum(doubles), Product(doubles));

        Console.WriteLine("Enter Int Numbers");
        int[] ints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        Console.WriteLine("Ints: Min:{0}, Max:{1}, Avarage:{2}, Sum;{3}, Product:{4}", Min(ints), Max(ints), Avarage(ints), Sum(ints), Product(ints));

    }
    static int Product(int[] ints)
    {
        int prod = 1;
        for (int i = 0; i < ints.Length; i++)
        {
            prod = prod * ints[i];
        }
        return prod;
    }
    static double Product(double[] doubles)
    {
        double prod = 1;
        for (int i = 0; i < doubles.Length; i++)
        {
            prod = prod * doubles[i];
        }
        return prod;
    }
    static int Sum(int[] ints)
    {
        int sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            sum = sum + ints[i];
        }
        return sum;
    }
    static double Sum(double[] doubles)
    {
        double sum = 0;
        for (int i = 0; i < doubles.Length; i++)
        {
            sum = sum + doubles[i];
        }
        return sum;
    }
    static decimal Avarage(int[] ints)
    {
        decimal avar = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            avar = avar + ints[i];
        }
        decimal result = avar / ints.Length;
        return result;
    }
    static double Avarage(double[] doubles)
    {
        double avar = 0;
        for (int i = 0; i < doubles.Length; i++)
        {
            avar = avar + doubles[i];
        }
        double result = Convert.ToDouble(avar) / doubles.Length;
        return result;
    }
    static int Max(int[] ints)
    {
        int max = int.MinValue;
        for (int i = 0; i < ints.Length; i++)
        {
            if (max < ints[i])
            {
                max = ints[i];
            }
        }
        return max;
    }

    static double Max(double[] doubles)
    {
        double max = Double.MinValue;
        for (int i = 0; i < doubles.Length; i++)
        {
            if (max < doubles[i])
            {
                max = doubles[i];
            }
        }
        return max;
    }

    static double Min(double[] doubles)
    {
        double min = Double.MaxValue;
        for (int i = 0; i < doubles.Length; i++)
        {
            if (min > doubles[i])
            {
                min = doubles[i];
            }
        }
        return min;
    }
    static int Min(int[] numbers)
    {
        int min = Int32.MaxValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
            }
        }
        return min;
    }
}

