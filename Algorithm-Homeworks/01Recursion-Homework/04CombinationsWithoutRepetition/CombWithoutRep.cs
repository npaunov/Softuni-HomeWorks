namespace _04CombinationsWithoutRepetition
{
    using System;

    class CombWithoutRep
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

        private static void Combinations(int n, int[] myArray, int index = 0, int start = 1)
        {
            if (index == myArray.Length)
            {
                Print(myArray);
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    myArray[index] = i;
                    Combinations(n, myArray, index + 1, i + 1);
                }
            }
        }

        private static void Print(int[] myArray)
        {
            Console.WriteLine("(" + string.Join(" ", myArray) + ")");
        }
    }
}

