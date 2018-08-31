/*This problem is from the Java Basics Exam (8 February 2015). You may check your solution here.
 You are given two jagged arrays. Each array represents a Lego block containing integers. Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] firstJagged = new int[n][];
        int[][] secondJagged = new int[n][];
        ConvertInputToJaggedArray(n, firstJagged);   //fill jagged arrays with input
        ConvertInputToJaggedArray(n, secondJagged);  //use method ConvertInputToJaggedArray
        int firstLine = firstJagged[0].Length + secondJagged[0].Length; //take firse line to compare to it
        bool isEqual = false;
        int result = 0;
       
        for (int i = 1; i < n; i++)                 //check if lines are equal
        {
            if (firstLine == firstJagged[i].Length + secondJagged[i].Length)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
                break;
            }
        }
        for (int i = 0; i < n; i++)                 // sum all elements in the arays
        {
            result = result + (firstJagged[i].Length + secondJagged[i].Length);
        }

        if (isEqual)                                // print result
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("[{0}, {1}]", string.Join(", ", firstJagged[i]), string.Join(", ", secondJagged[i].Reverse()));
            }
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("The total number of cells is: {0}", result);
        }


    }
    //use same method on both arrays
    static void ConvertInputToJaggedArray(int n, int[][] jagged)
    {
        for (int i = 0; i < n; i++)
        {
            jagged[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}

