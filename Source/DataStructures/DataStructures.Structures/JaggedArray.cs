using System;

namespace DataStructures.Structures
{
    public class JaggedArray
    {
        public static void Demo()
        {
            Console.WriteLine("JaggedArray......");
            Console.WriteLine();

            int[][] jagged = new int[3][];

            jagged[0] = new int[2];
            jagged[0][0] = 8;
            jagged[0][1] = 10;

            jagged[1] = new int[9];

            jagged[2] = new int[4] { 20, 30, 40, 50 };

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write($"Row[{i}]: {{ ");
                Console.Write(string.Join(", ", jagged[i]));
                Console.WriteLine(" }");
            }

            Console.WriteLine();
            Console.WriteLine("End of JaggedArray");
        }

    }
}
