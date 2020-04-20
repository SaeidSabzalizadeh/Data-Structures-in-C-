using System;

namespace DataStructures.Searchs
{
    public class BinarySearchSelfImplement
    {
        public static int Search(int[] sortedArray, int searchValue)
        {
            // Step 1 - intialize the variables
            int startIndex = 0;                  // beginning of the range
            int endIndex = sortedArray.Length - 1;       // the end of the range aka last slot

            // Step 2 - we do something (search for our value)
            while (startIndex <= endIndex)              // when true, we are still in the range
            {
                int midIndex = (startIndex + endIndex) / 2;    // find the midpoint
                if (searchValue < sortedArray[midIndex])
                    endIndex = midIndex - 1;          // set endIndex to mid point. We narrowed to 1st 
                                                      // half of the array in the case searchValue is less 
                                                      // the data in slot midIndex        

                else if (searchValue > sortedArray[midIndex])
                    startIndex = midIndex + 1;          // the opposite occurs. we bring startIndex to the 
                                                        // right of the array 
                else return midIndex;          // here we found our value b/c searchValue must =midIndex
            }

            // Step 3 - indicate not found
            return -1;
        }
    }
}
