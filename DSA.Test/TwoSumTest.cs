using DSA.Algorithms.Array;
using NUnit.Framework;

namespace DSA.Test
{
    public class TwoSumTest
    {
        [Test]
        public void Test_TwoSum()
        {
            var array = new int[] { 3, 3 };
            var result = TwoSumAlgorithm.TwoSum(array, 6);
            Assert.AreEqual(result, new int[] { 0,1 });
        }

    }
}
