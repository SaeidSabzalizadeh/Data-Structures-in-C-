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

            Demoing(JaggedArray.Demo);
            Demoing(LinearSearchFeatures.Demo);
            Demoing(BinarySearchFeatures.Demo);
            Demoing(QueueFeatures.Demo);
            Demoing(StackFeatures.Demo);
            Demoing(LinkedListFeatures.Demo);
            Demoing(SortFeatures.Demo);

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
