namespace _03CombinationsWithRepetition
{
    using System;

    class CombinationsRepetition
    {

        static void Main()
        {
            Console.WriteLine("k<=n");

            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k: ");
            int k = int.Parse(Console.ReadLine());
            int[] myArray = new int[k];

            Combinations(n, myArray);
        }

        private static void Combinations(int number, int[] myArray, int index = 0, int start = 1)
        {
            if (index == myArray.Length)
            {
                Print(myArray);
            }
            else
            {
                for (int i = start; i <= number; i++)
                {
                    myArray[index] = i;
                    Combinations(number, myArray, index + 1, i);
                }
            }
        }

        private static void Print(int[] myArray)
        {
            Console.WriteLine("(" + string.Join(" ", myArray) + ")");
        }
    }
}
