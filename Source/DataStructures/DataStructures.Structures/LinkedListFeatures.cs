using System;

namespace DataStructures.Structures
{
    public class LinkedListFeatures
    {
        public static void Demo()
        {

            string[] words = { "the", "actor", "jumped", "over", "the", "director" };
            System.Collections.Generic.LinkedList<string> sentence = new System.Collections.Generic.LinkedList<string>(words);
            Display(sentence, "The linked list values:");


            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");


            System.Collections.Generic.LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node:");


            sentence.RemoveFirst();
            System.Collections.Generic.LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");

            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");

            current = sentence.Find("actor");
            IndicateNode(current, "Test 7: Indicate the 'actor' node:");

            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "skinny");
            IndicateNode(current, "Test 8: Add 'quick' and 'skinny' before 'actor':");


            Console.ReadLine();
        }

        private static void Display(System.Collections.Generic.LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(System.Collections.Generic.LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            System.Text.StringBuilder result = new System.Text.StringBuilder("(" + node.Value + ")");
            System.Collections.Generic.LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
