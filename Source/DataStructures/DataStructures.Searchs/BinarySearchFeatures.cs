using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Searches
{
   public class BinarySearchFeatures
    {
        public static void Demo()
        {
            Console.WriteLine("Binary Search......");

            string[] dinners = {"Pasta",
                              "Apple Pie",
                              "Tuna Melt",
                              "Mushroom Omelet",
                              "Duck",
                              "Eggplant"};

            Console.WriteLine();
            Console.WriteLine("\nContent of array:");
            Console.WriteLine("------------------");
            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nContent after Sort:");
            Console.WriteLine("------------------");
            Array.Sort(dinners);

            foreach (string dinner in dinners)
            {
                Console.WriteLine(dinner);
            }

            Console.WriteLine("\nBinarySearch for 'Beet Salad':");
            int index = Array.BinarySearch(dinners, "Beet Salad");
            DislpayWhere(dinners, index);

            Console.WriteLine("\nBinarySearch for 'Tuna Melt':");
            index = Array.BinarySearch(dinners, "Tuna Melt");
            DislpayWhere(dinners, index);

            Console.WriteLine("End of Binary Search");
        }

        private static void DislpayWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index;

                Console.Write("Not found. Sorts between: ");

                if (index == 0)
                    Console.Write("beginning of array and ");
                else
                    Console.Write("{0} and ", array[index - 1]);

                if (index == array.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine("{0}.", array[index]);
            }
            else
            {
                Console.WriteLine("Found at index {0}.", index);
            }
        }


    }
}
