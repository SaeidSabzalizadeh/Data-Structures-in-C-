namespace DataStructures.Sorts
{
    public class InsertionSort : ISort
    {
        public string Name => nameof(InsertionSort);

        public int[] Sort(int[] entry)
        {
            int currentItem;

            for (int i = 1; i < entry.Length; i++)
            {
                currentItem = entry[i];
                int currentIndex = i;

                while (currentIndex > 0 && entry[currentIndex - 1] > currentItem)
                {
                    entry[currentIndex] = entry[currentIndex - 1];
                    currentIndex--;
                }

                entry[currentIndex] = currentItem;
            }

            return entry;
        }
    }
}
