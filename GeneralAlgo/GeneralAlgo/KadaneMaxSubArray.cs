using System;

namespace GeneralAlgo
{
    public static class KadaneMaxSubArray
    {
        public static int MaxSubArray(int[] array)
        {
            int globalMax = 0;
            int localMax = 0;
            for (int index = 0; index < array.Length; index++)
            {
                localMax = Math.Max(array[index], localMax + array[index]);
                if (localMax > globalMax)
                    globalMax = localMax;
            }
            return globalMax;
        }
    }
}
