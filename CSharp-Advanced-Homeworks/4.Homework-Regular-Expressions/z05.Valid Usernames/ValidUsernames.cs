using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ValidUsernames
{
    /*Problem 5* Valid Usernames
    This problem is from the Java Basics Exam (21 September 2014 Evening). You may check your solution here.
    You are part of the back-end development team of the next Facebook. You are given a line of usernames, between one of the following symbols: space, “/”, “\”, “(“, “)”. First you have to export all valid usernames. A valid username starts with a letter and can contain only letters, digits and “_”. It cannot be less than 3 or more than 25 symbols long. Your task is to sum the length of every 2 consecutive valid usernames and print on the console the 2 valid usernames with biggest sum of their lengths, each on a separate line. 
*/
    static void Main()
    {
        string sentence = Console.ReadLine();
        //string sentence = @"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref";
        //Using  Look Behind and Look forward tho check end and begining of the username
        string pattern = @"(?<=[\ \/\\\(\)]|^)([a-zA-Z][\w]{2,24})(?=[\ \/\\\(\)]|$)";
        Regex reg = new Regex(pattern);
        MatchCollection matches = reg.Matches(sentence);
        int first = 0;
        int second = 0;
        int bestsum = 0;

        for (int i = 0; i < matches.Count - 1; i++)
        {
            //Compare if the current two elements are longer than these before
            int sum = matches[i].Length + matches[i + 1].Length;
            if (sum > bestsum)
            {
                first = i;
                second = i + 1;
                bestsum = sum;
            }
        }
        Console.WriteLine(matches[first]);
        Console.WriteLine(matches[second]);




    }
}


