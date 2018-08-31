/*Write a program that reads from the console a number N and an array of integers given on a single line. Your task is to find all subsets within the array which have a sum equal to N and print them on the console (the order of printing is not important). Find only the unique subsets by filtering out repeating numbers first. In case there aren't any subsets with the desired sum, print "No matching subsets.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubsetSums
{
    static List<List<int>> biglist = new List<List<int>>();
    static List<int> input;
    static int sum;
    static void Main()
    {
        sum = int.Parse(Console.ReadLine());
        List<int> output = new List<int>();
        input = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToList();
        input.Add(0);
        Combinations(0, output);                // fills biglist with all combinations of two elements ore more
        biglist.RemoveAt(biglist.Count - 1);    // removes the last
        foreach (List<int> tempList in biglist)
        {
            tempList.RemoveAt(tempList.Count - 1);
        }

        List<List<int>> littlelist = new List<List<int>>(); // filter the lisis only equal to input sum
        foreach (List<int> temp in biglist)
        {
            if (temp.Sum() == sum)
            {
                littlelist.Add(temp);
            }
        }

        if (littlelist.Count == 0)                          //print the results
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (List<int> newlist in littlelist)
            {
                Console.WriteLine(" {0} = {1}", string.Join(" + ", newlist), sum);
            }
        }
        //foreach (List<int> subList in biglist)  // loop throough list to print them on separate lines
        //{
        //    foreach (var item in subList)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

    }
    static void Combinations(int index, List<int> output)
    {
        if (index == input.Count)
        {
            biglist.Add(new List<int>(output));
            return;
        }
        for (int i = index; i < input.Count; i++)
        {
            output.Add(input[i]);
            Combinations(i + 1, output);
            output.RemoveAt(output.Count - 1);
        }
    }

}


