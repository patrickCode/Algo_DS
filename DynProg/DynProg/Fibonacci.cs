using System;

namespace DynProg
{
    // 0 1 1 2 3 5 8 13 21 34
    public static class Fibonacci
    {
        public static int Calculate(int n)
        {
            int[] cache = new int[n];
            for (int idx = 0; idx < cache.Length; idx++)
            {
                cache[idx] = -1;
            }
            cache[0] = 0;
            cache[1] = 1;

            int fibValue = Calculate(n, cache);
            return fibValue;
        }

        private static int Calculate(int n, int[] cache)
        {
            if (cache[n - 1] > -1)
                return cache[n - 1];

            int value = Calculate(n - 1, cache) + Calculate(n - 2, cache);
            cache[n - 1] = value;
            return value;
        }

        public static void Test()
        {
            int n = 10;
            Console.WriteLine($"Fibonacci value at {n}: {Calculate(n)}");
        }
    }
}
