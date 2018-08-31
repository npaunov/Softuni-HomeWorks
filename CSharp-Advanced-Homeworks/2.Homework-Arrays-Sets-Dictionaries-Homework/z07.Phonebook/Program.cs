using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> pnoneDictionary = new Dictionary<string, List<string>>();
        string text;
        string[] name;
        while (!((text = Console.ReadLine()) == "search"))
        {
            name = text.Split('-');
            if (!pnoneDictionary.Keys.Contains(name[0]))
            {
                pnoneDictionary[name[0]] = new List<string>();
            }
            pnoneDictionary[name[0]].Add(name[1]);
        }
        if (text == "search")
        {
            while (!((text = Console.ReadLine()) == "END"))
            {
                if (pnoneDictionary.Keys.Contains(text))
                {
                    foreach (var item in pnoneDictionary[text])
                    {
                        Console.WriteLine("{0} -> {1}", text, item);
                    }
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", text);
                }
            }
        }
    }
}