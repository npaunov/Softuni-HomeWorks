/*This problem is from the Java Basics Exam (26 May 2014). You may check your solution here.
George likes math. Recently he discovered an interesting property of the Pythagorean Theorem: there are infinite number of triplets of integers a, b and c (a ≤ b), such that a2 + b2 = c2. Write a program to help George find all such triplets (called Pythagorean numbers) among a set of integer numbers.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int first = 0;
        int second = 0;
        int third = 0;
        bool foundNumber = false;

        for (first = 0; first < numbers.Length; first++)
        {
            for (second = 0; second < numbers.Length; second++)
            {
                for (third = 0; third < numbers.Length; third++)
                {
                    if ((Math.Pow(numbers[first], 2) + Math.Pow(numbers[second], 2) == Math.Pow(numbers[third], 2)) && numbers[first] <= numbers[second])
                    {
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", numbers[first], numbers[second], numbers[third]);
                        foundNumber = true;
                    }
                }
            }
        }
        if (!foundNumber)
        {
            Console.WriteLine("No");
        }
    }
}

