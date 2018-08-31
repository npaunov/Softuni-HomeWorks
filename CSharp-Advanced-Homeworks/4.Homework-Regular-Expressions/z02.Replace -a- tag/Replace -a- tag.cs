using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        //Note: The input may be read on a single line (unlike the example above) or from a file. Remove all new lines if you choose the first approach.

        //string text = "<a href=http://softuni.bg>SoftUni</a>";
        string text = Console.ReadLine();
        // We take only the middle 2 groups of the text : href=http://softuni.bg, SoftUni
        string patternToRepalce = @"(<a)(?<begin>.*(?=>))(>)(?<end>.*(?<=))(<\/a>)";
        Regex pattern = new Regex(patternToRepalce);
        //we take the new pattern [URL ...][/URL] and the 2 goups
        string newReplacement = @"[URL${begin}]${end}[/URL]";
        // and foprm a new string
        string result = pattern.Replace(text, newReplacement);
        Console.WriteLine(result);

    }
}

