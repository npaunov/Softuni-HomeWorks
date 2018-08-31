/*Write a program that reads N floating-point numbers from the console. Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CategorizeNumbers
{
    static void Main(string[] args)
    {
        string arrString = Console.ReadLine();
        string[] items = arrString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        List<int> numbers = new List<int>();
        List<float> floats = new List<float>();

        for (int i = 0; i < items.Length; i++)
        {
            if (float.Parse(items[i]) % 1 == 0)
            {
                numbers.Add((int)Convert.ToDouble(items[i]));
            }
            else
            {
                floats.Add(float.Parse(items[i]));
            }
        }
        Console.WriteLine();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", String.Join(", ", floats), floats.Min(), floats.Max(), floats.Sum(), floats.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", String.Join(", ", numbers), numbers.Min(), numbers.Max(), numbers.Sum(), numbers.Average());
        Console.WriteLine();
    }
}

