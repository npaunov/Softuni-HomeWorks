using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        //string text = "Please contact us at: support@github.com.";
        //string text = "Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.";
        //string text = "Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.";

        string text = Console.ReadLine();
        //The whole match is one group it always has @ in the miggle and "." at the and folowed by at least 2 letters
        string pattern = @"(?<=\s)([a-z]+\.*\-*[a-z0-9]*@[a-z]+[_.-]*[a-z0-9]*[a-z0-9.\-_]*\.[a-z]{2,})";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(text);

        foreach (var match in matches)
        {
            Console.WriteLine("{0}", match);
        }


        

    }
}

