using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CountSymbols
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToArray();
        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        foreach (char item in text)
        {
            if (dictionary.ContainsKey(item))
                dictionary[item]++;
            else
                dictionary.Add(item, 1);
        }

        char[] keys = dictionary.Keys.OrderBy(p => p).ToArray();
        foreach (char key in keys)
            Console.WriteLine("{0}: {1} time/s", key, dictionary[key]);
    }
}
