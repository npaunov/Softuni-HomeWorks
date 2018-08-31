using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class SentenceExtractor
{
    static void Main()
    {
        string input = Console.ReadLine();
        //string sentence = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
        string sentence = Console.ReadLine();
        // We replace the input string in the pattern
        string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=[.!?])[.!?])(?=\s|$)",input);
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(sentence);

        foreach (var match in matches)
        {
            Console.WriteLine("{0}", match);
        }
    }
}
