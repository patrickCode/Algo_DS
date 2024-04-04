using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Given an array of integers, and an integer N, find the length of the longest “N-stable” continuous
subarray.
An array is defined to be “N-stable” when the pair-wise difference between any two elements in the
array is smaller or equal to N.
A subarray of a 0-indexed integer array is a contiguous non-empty sequence of elements within an
array.
For instance, for array [ 4, 2, 3, 6, 2, 2, 3, 2, 7 ], and N = 1
The return value should be 4, since the longest 1-stable subarray is [ 2, 2, 3, 2 ].
For [8,2,4,7] and N = 4. Should return 2 because longest N-stable subarray is [2,4](or [4,7])
 */
namespace GeneralAlgo
{
    internal class StableContinousSubArray
    {
        public List<int> Find(List<int> list, int interval)
        {
            if (list == null || list.Count == 0 || interval < 0) return null;
            if (list.Count == 1) return list;

            List<int> result = new();
            List<int> tempResult = new() { list[0] };
            int localMax = list[0] + interval;
            int localMin = list[0] - interval;

            for (int index = 1; index < list.Count; index++)
            {   
                bool canBeAddedToStableArray = list[index] <= localMax && list[index] >= localMin;
                if (canBeAddedToStableArray)
                {
                    tempResult.Add(list[index]);
                    int newLocalMax = list[index] + interval; ;
                    int newLocalMin = list[index] - interval;
                    localMax = Math.Min(localMax, newLocalMax);
                    localMin = Math.Max(localMin, newLocalMin);
                    continue;
                }

                // Update the result
                if (result.Count < tempResult.Count)
                {
                    result = tempResult.ToArray().ToList();
                }
                tempResult = new List<int> { list[index] };
                localMax = list[index] + interval;
                localMin = list[index] - interval;
            }

            return result;
        }
    }
}
