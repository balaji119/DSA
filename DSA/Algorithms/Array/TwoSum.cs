using System.Collections.Generic;

namespace DSA.Algorithms.Array
{
    /**
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.

    Example 1:

    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Output: Because nums[0] + nums[1] == 9, we return [0, 1].
     **/
    public class TwoSumAlgorithm
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                var diff = target - num;
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[diff], i };
                }
                dict[num] = i;
            }

            return null;
        }
    }
}
