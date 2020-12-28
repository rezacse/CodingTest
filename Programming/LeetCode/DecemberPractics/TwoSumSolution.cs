using System;
using System.Collections.Generic;

namespace Programming.LeetCode.DecemberPractics
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hash = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num2 = target - nums[i];
                if (hash.ContainsKey(num2))
                    return new int[] { i, hash[num2] };
                hash.Add(nums[i], i);
            }

            throw new Exception("Not found!");
        }
    }
}
