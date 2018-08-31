//Zadacha sus *
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class GenericArraySort
{
    static void Main()
    {
        int[] n = { 1, 3, 4, 5, 1, 0, 5 };
        string[] text = { "zaz", "cba", "baa", "azis" };
        DateTime[] datetimes =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
        };

        Console.WriteLine(SortArray(n));
        Console.WriteLine(SortArray(text));
        Console.WriteLine("{0:MM/dd/yy H:mm:ss zzz}", SortArray(datetimes));
    }

    private static string SortArray<T>(IEnumerable<T> arrayEntry)
    {
        List<T> tempList = arrayEntry.ToList();
        List<T> sorted = new List<T>();

        while (tempList.Count != 0)
        {
            var temp = tempList.Min();
            sorted.Add(temp);
            tempList.Remove(temp);
        }
        return PrintArray(sorted);
    }

    static string PrintArray<T>(IEnumerable<T> array)
    {
        return string.Join(", ", array);
    }
}
