using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] text = Console.ReadLine().Split(' ').ToArray();
        Dictionary<string, string> allInput = new Dictionary<string, string>(); //create Dictionary
        for (int i = 0; i < text.Length; i++)                                   //fill it with combinations
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (!allInput.ContainsKey(string.Concat(text[i], "|", text[j])))
                {
                    if (i != j)
                    {
                        allInput.Add(string.Concat(text[i], "|", text[j]), string.Concat(text[i], text[j]));
                    }
                }
                if (!allInput.ContainsKey(string.Concat(text[j], "|", text[i])))
                {
                    if (i != j)
                    {
                        allInput.Add(string.Concat(text[j], "|", text[i]), string.Concat(text[j], text[i]));
                    }
                }

            }
        }

        var lookup = allInput.ToLookup(x => x.Value, x => x.Key).Where(x => x.Count() > 1); //look for duplicate values
        foreach (var item in lookup)                                
        {
            var keys = item.Aggregate("", (s, v) => s + " " + v);                           //print the keys
            var message = keys;
            var keysReverse = item.Aggregate("", (s, v) => v + " " + s); ;
            Console.WriteLine(message);
            Console.WriteLine(" " + keysReverse);
        }
    }
}

