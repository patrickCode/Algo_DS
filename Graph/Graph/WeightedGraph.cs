using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length < 2 && k <= 1)
                return nums;

            Array.Sort(nums);
            List<int> result = new List<int>();

            for (int index = 1; index < nums.Length; index++)
            {
                int currentFrequency = 1;
                while (nums[index - 1] == nums[index] && index < nums.Length)
                {
                    currentFrequency++;
                    index++;
                }

                if (currentFrequency >= k)
                {
                    result.Add(nums[index - 1]);
                }
            }

            return result.ToArray();
        }
    }
}
