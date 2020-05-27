using System;

namespace DataStructures.Structures
{

    public class TrieFeatures
    {
        public static void Demo()
        {
            Trie trie = new Trie();

            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        Console.WriteLine($"Inserted: {inputs[i]}");
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Console.WriteLine($"Search for: {inputs[i] } returnes: '{searchResult}' as expected: '{expectedResults[i]}'");
                        break;

                    case "startsWith":
                        var StartsWithResult = trie.StartsWith(inputs[i]);
                        Console.WriteLine($"StartsWith for: {inputs[i]} returnes: '{StartsWithResult}' as expected: '{expectedResults[i]}'");
                        break;

                    default:
                        break;
                }

            }

        }
    }

    public class Trie
    {
        TrieNode root;

        public Trie()
        {
        }

        public void Insert(string word)
        {
            if (word.Length > 0)
                root = Insert(root, word, 0);
        }

        public bool Search(string word)
        {
            if (string.IsNullOrEmpty(word))
                return false;

            var node = Search(root, word, 0);
            return node != null && node.IsWord;
        }

        public bool StartsWith(string prefix)
        {
            if (string.IsNullOrEmpty(prefix))
                return false;

            var node = Search(root, prefix, 0);
            return node != null;
        }


        private TrieNode Insert(TrieNode node, string word, int wordIndex)
        {
            char c = word[wordIndex];

            if (node == null)
                node = new TrieNode(c);

            if (c > node.Key)
                node.Right = Insert(node.Right, word, wordIndex);

            else if (c < node.Key)
                node.Left = Insert(node.Left, word, wordIndex);

            else if (c == node.Key)
            {
                if (wordIndex < word.Length - 1)
                    node.Middle = Insert(node.Middle, word, wordIndex + 1);

                else
                    node.IsWord = true;
            }

            return node;
        }

        private TrieNode Search(TrieNode node, string word, int wordIndex)
        {
            if (node == null)
                return node;

            char c = word[wordIndex];

            if (c > node.Key)
                node = Search(node.Right, word, wordIndex);

            else if (c < node.Key)
                node = Search(node.Left, word, wordIndex);

            else if (wordIndex < word.Length - 1)
                node = Search(node.Middle, word, ++wordIndex);

            return node;
        }

    }

    public class TrieNode
    {
        public char Key;
        public bool IsWord;

        public TrieNode Left;
        public TrieNode Right;
        public TrieNode Middle;

        public TrieNode(char key)
        {
            Key = key;
        }
    }
}
