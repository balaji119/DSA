using System;

namespace DSA.Algorithms.Sort
{
    public static class Counting
    {
        public static void CountingSort(this int[] array)
        {
            if (array.Length == 0) return;

            var max = FindMaxNum(array);
            var countArray = new int[max + 1];

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    throw new InvalidOperationException("Counting sort doesn't support negative numbers");
                countArray[array[i]]++;
            }

            var arrayIndex = 0;
            for (var i = 0; i < countArray.Length; i++)
            {
                var val = countArray[i];
                for (var j = 0; j < val; j++)
                {
                    array[arrayIndex++] = i;
                }
            }
        }

        private static int FindMaxNum(int[] array)
        {
            var max = int.MinValue;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
    }
}
