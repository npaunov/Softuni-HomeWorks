/*Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. Use the method from the previous exercise in order to re.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 }; // pre-defined sequences
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 }; // pre-defined sequences
        int[] sequenceThree = { 1, 1, 1 };           // pre-defined sequences

        //User input:
        int[] consoleinput = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine("sequenceOne: " + GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine("sequenceTwo: " + GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine("sequenceThree: " + GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        Console.WriteLine("User input result:" + GetIndexOfFirstElementLargerThanNeighbours(consoleinput));


    }
    static int GetIndexOfFirstElementLargerThanNeighbours(int[] numArray)
    {
        int result = -1;
        int n = 0;
        while (n < numArray.Length)
        {
            if ((n == 0 || n == numArray.Length - 1))
            {
                if (numArray[Math.Abs(n - 1)] < numArray[n])
                {
                    result = n;
                    break;
                }
                else
                {
                    n++;
                    continue;
                }
            }
            else if (numArray[n] > numArray[n - 1] && numArray[n] > numArray[n + 1])
            {
                result = n;
                break;
            }
            n++;
        }
        return result;
    }
}

