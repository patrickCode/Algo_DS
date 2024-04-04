using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgo
{
    public class ArrHash
    {
        public int[] GetTopFrequent(int[] nums, int k)
        {
            if (nums.Length < 2 && k <= 1)
                return nums;

            Array.Sort(nums);
            List<int> result = new();

            for (int index = 1; index < nums.Length; index++)
            {
                int currentFrequency = 1;
                while (index < nums.Length && nums[index - 1] == nums[index])
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
