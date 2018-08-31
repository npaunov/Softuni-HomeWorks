﻿namespace _01TowerOfHanoi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TowerOfHanoi
    {
        private static int stepsTaken = 0;

        private static Stack<int> source = new Stack<int>();
        private static readonly Stack<int> destination = new Stack<int>();
        private static readonly Stack<int> spare = new Stack<int>();

        static void Main()
        {
            int numberOfDisks = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());

            PrintPegs();
            MoveDisks(numberOfDisks, source, destination, spare);


            // Console.WriteLine();
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
                PrintRods();
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                destination.Push(source.Pop());
                stepsTaken++;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk {bottomDisk}");
                PrintRods();
                MoveDisks(bottomDisk - 1, spare, destination, source);

            }
        }

        private static void PrintRods()
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine();
        }
        private static void PrintPegs()
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare));
            Console.WriteLine();
        }
    }
}
