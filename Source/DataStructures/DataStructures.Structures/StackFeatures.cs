using System;

namespace DataStructures.Structures
{
    public class StackFeatures
    {
       public static void Demo()
        {

            Console.WriteLine("Stack......");

            System.Collections.Generic.Stack<string> names = new System.Collections.Generic.Stack<string>();
            names.Push("Andrew");
            names.Push("Bobby");
            names.Push("Candy");
            names.Push("Dana");
            names.Push("Edith");

            Console.WriteLine("Default content of stack");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nPopping '{0}'", names.Pop());
            Console.WriteLine("Peek at next item to display what will" + " be destacked: {0}", names.Peek());
            Console.WriteLine("Now, after peek, popping '{0}'", names.Pop());


            System.Collections.Generic.Stack<string> stack2 = new System.Collections.Generic.Stack<string>(names.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string name in stack2)
            {
                Console.WriteLine(name);
            }

            string[] array2 = new string[names.Count * 2];
            names.CopyTo(array2, names.Count);

            System.Collections.Generic.Stack<string> stack3 = new System.Collections.Generic.Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with " + "duplicates and nulls:");
            foreach (string name in stack3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nstack2.Contains(\"Dana\") = {0}", stack2.Contains("Dana"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

            Console.WriteLine("End of Stack");
        }
    }
}
