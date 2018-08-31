using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SerierOfLetters
{
    static void Main()
    {
        //string text = "aaaaabbbbbcdddeeeedssaa";

        string text = Console.ReadLine();
        Console.WriteLine("{0}", Regex.Replace(text, @"(\w)\1{1,}", "$1"));
    }
}

