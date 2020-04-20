using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Searches
{
    public class LinearSearchSelfImplement
    {
        public static int Search(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
