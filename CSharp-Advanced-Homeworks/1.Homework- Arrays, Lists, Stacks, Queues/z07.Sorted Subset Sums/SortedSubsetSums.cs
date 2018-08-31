/*Modify the program you wrote for the previous problem to print the results in the following way: each line should contain the operands (numbers that form the desired sum) in ascending order; the lines containing fewer operands should be printed before those with more operands; when two lines have the same number of operands, the one containing the smallest operand should be printed first. If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important. */

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

        var result = littlelist.OrderBy(a => a.Count).ThenBy(a => a.Min()); // sort the lists

        if (littlelist.Count == 0)                          //print the results
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            foreach (List<int> newlist in result)
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


