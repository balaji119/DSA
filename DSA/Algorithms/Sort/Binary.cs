namespace DSA.Algorithms.Sort
{
    public static class Binary
    {
        public static void BinarySort(this int[] array)
        {
            var startIndex = GetStartIndex(array, 0);
            var endIndex = GetEndIndex(array, array.Length - 1);

            while (startIndex < endIndex)
            {
                Swap(array, startIndex, endIndex);
                startIndex = GetStartIndex(array, startIndex);
                endIndex = GetEndIndex(array, endIndex);
            }
        }

        private static int GetStartIndex(int[] array, int index)
        {
            while (index < array.Length && array[index] == 0)
            {
                index++;
            }
            return index;
        }

        private static int GetEndIndex(int[] array, int index)
        {
            while (index >= 0 && array[index] == 1)
            {
                index--;
            }
            return index;
        }

        private static void Swap(int[] arr, int pos1, int pos2)
        {
            var temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
    }
}
