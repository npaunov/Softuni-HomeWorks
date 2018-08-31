/*Write a program to find all increasing sequences inside an array of integers. The integers are given on a single line, separated by a space. Print the sequences in the order of their appearance in the input array, each at a single line. Separate the sequence elements by a space. Find also the longest increasing sequence and print it at the last line. If several sequences have the same longest length, print the left-most of them.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSeq
{
    static void Main()
    {
        //we crete a list of lists to strore each different sequence
        List<int> input = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToList();
        List<List<int>> myList = new List<List<int>>();
        int counter = 0;

        //with this while we search the whole list and take eache number as sequence
        while (counter < input.Count)
        {
            List<int> sublist = new List<int>();
            //with this while we check if the next number is larger in that case we take it as separate sequence
            while ((counter < input.Count - 1) && (input[counter] < input[counter + 1]))
            {
                sublist.Add(input[counter]);
                counter++;
            }
            sublist.Add(input[counter]);
            counter++;
            myList.Add(sublist); //we add either only one number or more if they are a sequence to the final list

        }

        int listLength = 0;
        foreach (List<int> subList in myList) // loop throough list to print them on separate lines
        {
            foreach (var item in subList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < myList.Count - 1; i++) // we look for the longest list in all sub-lists
        {
            if ((myList[i].Count < myList[i + 1].Count) && (myList[i + 1].Count > myList[listLength].Count))
            {
                listLength = i + 1;
            }

        }

        Console.WriteLine("Longest: {0}", String.Join(" ", myList[listLength])); //print the longest list

    }
}

