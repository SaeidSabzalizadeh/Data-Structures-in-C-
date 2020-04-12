using DataStructures.Sorts;
using System;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting......");
            Console.WriteLine();

            ISort sortEngine = new BubbleSort();

            int[] numbers = new int[] { 3, 5, 1, 4, 7, 6, 2 };

            Console.WriteLine($"Main Array: {string.Join(", ", numbers)}");
            Console.WriteLine();

            int[] sortedNumbers = sortEngine.Sort(numbers);

            Console.WriteLine($"Sorted Array: {string.Join(", ", sortedNumbers)}");

            Console.WriteLine();
            Console.WriteLine("End");
            Console.ReadLine();


        }
    }
}
