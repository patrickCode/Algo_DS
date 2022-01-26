using System;

namespace GeneralAlgo
{   
    /* Reference: https://www.youtube.com/watch?v=lXVy6YWFcRM
     * We need to maintain the local maximum and local minimum at every interval. Since 2 negative multiplications can give a positive,
     * we need to maintain the local minimum, since the local minimum can become maximum if gets multipliplied by a negative number.
     * At zero we will need to reset the subarray
    */
    public static class MaxSubProduct
    {
        public static int MaxProduct(int[] array)
        {
            int globalMax = array[0];
            int localMax = globalMax;
            int localMin = globalMax;

            for (int index = 1; index < array.Length; index++)
            {
                localMax = array[index] != 0
                     ? GetMax(localMax * array[index], localMin * array[index], array[index])
                     : 1;
                localMin = array[index] != 0
                    ? GetMin(localMax * array[index], localMin * array[index], array[index])
                    : 1;
                
                if (array[index] == 0)
                    continue;

                if (localMax > globalMax)
                    globalMax = localMax;
            }
            return globalMax;
        }

        private static int GetMax(int value1, int value2, int value3)
        {
            return Math.Max(Math.Max(value1, value2), value3);
        }

        private static int GetMin(int value1, int value2, int value3)
        {
            return Math.Min(Math.Min(value1, value2), value3);
        }
    }
}
