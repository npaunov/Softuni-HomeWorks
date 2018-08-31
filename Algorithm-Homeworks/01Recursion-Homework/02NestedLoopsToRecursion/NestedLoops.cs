namespace _02NestedLoopsToRecursion
{
    using System;

    class NestedLoops
    {
        static void Main()
        {

            int number = int.Parse(Console.ReadLine());
            int[] myArray = new int[number];
            NestedLoopsRecursion(number, myArray);
        }

        private static void NestedLoopsRecursion(int number, int[] myArray, int index = 0)
        {
            if (index == number)
            {
                Print(myArray);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    myArray[index] = i;
                    NestedLoopsRecursion(number, myArray, index + 1);
                }
            }
        }

        private static void Print(int[] myArray)
        {
            Console.WriteLine(string.Join(", ", myArray));
        }
    }
}
