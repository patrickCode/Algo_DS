using System;
using System.Collections.Generic;

namespace DynProg
{
    // Given a target sum and an array of positive numbers, find out if any combination of numbers from the array (repetition allowed) sums up to the target
    public class ArrSum
    {
        public static bool CanSum(int target, int[] array)
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>();
            Array.Sort(array);

            memo.Add(0, true);
            foreach (var num in array)
            {
                memo.Add(num, true);
            }
            return CanSum(target, array, memo);
        }

        private static bool CanSum(int target, int[] array, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(target))
                return memo[target];

            if (target < 0)
                return false;

            if (target < array[0])
            {
                memo[target] = false;
                return false;
            }

            foreach(int num in array)
            {
                int remainderTarget = target - num;
                bool canSum = CanSum(remainderTarget, array, memo);
                memo[remainderTarget] = canSum;
                if (canSum)
                    return true;
            }
            memo[target] = false;
            return false;
        }

        public static void Test()
        {
            int[] array = new int[] { 5, 3, 4 };
            int target = 7;
            bool canSum = CanSum(target, array);
            Console.WriteLine(canSum);
        }
    }
}
