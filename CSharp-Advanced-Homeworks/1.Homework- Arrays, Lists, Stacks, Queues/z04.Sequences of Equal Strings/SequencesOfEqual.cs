/*Write a program that reads an array of strings and finds in it all sequences of equal elements (comparison should be case-sensitive). The input strings are given as a single line, separated by a space.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class SequencesOfEqual
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        string output = String.Empty;

        while (input.Count > 0)
        {
            string temp = input[0];
            if (input.Count == 1)
            {
                output = output + temp + " ";
                input.Remove(input[0]);
            }
            else
            {
                if (input[0] == input[1])
                {
                    output = output + temp + " ";
                    input.Remove(input[0]);
                }
                else
                {
                    output = output + temp + " " + "niamatakuvHAK";
                    input.Remove(input[0]);
                }
            }
        }
        string resultLine = output.Replace("niamatakuvHAK", "" + System.Environment.NewLine);
        Console.WriteLine(resultLine);

    }
}

