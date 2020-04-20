using System;
using System.Linq;

namespace DataStructures.Sorts
{
    public class Sort
    {
        static int[] Numbers = new int[] { 3, 5, 1, 4, 7, 6, 2, 4, 9 };
        static int[] SortedNumbers = new int[] { 1, 2, 3, 4, 4, 5, 6, 7, 9 };

        public static void DemoDifferentSortsFeatures()
        {
            Console.WriteLine("Sorting......");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"Main Array: {string.Join(", ", Numbers)}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            GetSorted(new BubbleSort(), Numbers);
            GetSorted(new InsertionSort(), Numbers);
            GetSorted(new SelectionSort(), Numbers);

            Console.WriteLine("End");
            Console.ReadLine();
        }

        private static void GetSorted(ISort sortEngine, int[] numbers)
        {
            int[] clonedNumbers = new int[numbers.Length];
            numbers.ToList().CopyTo(clonedNumbers);

            int[] sortedNumbers = sortEngine.Sort(clonedNumbers);

            Console.WriteLine($"Sorted by {sortEngine.Name}({Validate(sortedNumbers)}): {string.Join(", ", sortedNumbers)}");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine();
        }

        private static bool Validate(int[] numbers)
        {
            if (!numbers.Any() || numbers.Length != SortedNumbers.Length)
                return false;

            for (int i = 0; i < SortedNumbers.Length; i++)
            {
                if (numbers[i] != SortedNumbers[i])
                    return false;
            }

            return true;
        }

    }
}
