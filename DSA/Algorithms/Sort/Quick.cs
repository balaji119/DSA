namespace DSA.Algorithms.Sort
{
    public static class Quick
    {
        public static void QuickSort(this int[] array)
        {
            QuickSort(array, 0, array.Length - 1, array[array.Length - 1]);
        }

        private static void QuickSort(int[] array, int startIndex, int endIndex, int pivot)
        {
            if (startIndex >= endIndex)
                return;

            var partitionIndex = startIndex - 1;
            for (var i = startIndex; i <= endIndex; i++)
            {
                if (array[i] <= pivot)
                {
                    Swap(array, i, ++partitionIndex);
                }
            }

            QuickSort(array, startIndex, partitionIndex - 1, array[partitionIndex - 1]);
            QuickSort(array, partitionIndex + 1, endIndex, array[endIndex]);
        }

        private static void Swap(int[] arr, int pos1, int pos2)
        {
            var temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
    }
}
