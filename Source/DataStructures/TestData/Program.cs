using DataStructures.Searches;
using DataStructures.Sorts;
using DataStructures.Structures;
using System;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************** Start ***************************************");

            Demoing(SortFeatures.Demo);
            Demoing(LinkedListFeatures.Demo);
            Demoing(StackFeatures.Demo);
            Demoing(QueueFeatures.Demo);
            Demoing(BinarySearchFeatures.Demo);

            Console.WriteLine("*************************************** End ***************************************");
            Console.ReadLine();
        }

        private static void Demoing(Action demo)
        {
            demo();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
