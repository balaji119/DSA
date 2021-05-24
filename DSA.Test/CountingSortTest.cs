using DSA.Algorithms.Sort;
using NUnit.Framework;
using System;

namespace DSA.Test
{
    public class CountingSortTest
    {

        [Test]
        public void Test_CountingSort_WithPostiveNumbers()
        {
            var array = new int[] { 4, 5, 7, 9, 8, 1, 3, 2, 0, 6 };
            array.CountingSort();
            Assert.AreEqual(array, new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [Test]
        public void Test_CountingSort_EmptyArray()
        {
            var array = Array.Empty<int>();
            array.CountingSort();
            Assert.AreEqual(array, Array.Empty<int>());
        }

        [Test]
        public void Test_CountingSort_WithNegativeNumbers()
        {
            var array = new int[] { -1, 1, 2 };
            Assert.Throws(typeof(InvalidOperationException), () => { array.CountingSort(); });
        }
    }
}