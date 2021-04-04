using System;
using System.Collections.Generic;

namespace DynProg
{
    // Given a target sum and an array of positive numbers, find out if any combination of numbers from the array (repetition allowed) sums up to the target
    // Time: O(m * n)
    // Space: O(m)
    public class ArrSum
    {
        public static int[] CanSum(int target, int[] array)
        {
            Dictionary<int, bool> memo = new Dictionary<int, bool>();
            Array.Sort(array);
            Array.Reverse(array);

            memo.Add(0, true);
            foreach (var num in array)
            {
                memo.Add(num, true);
            }
            List<int> path = new List<int>();
            bool canSum = CanSum(target, array, memo, path);
            if (canSum)
                return path.ToArray();
            return Array.Empty<int>();
        }

        private static bool CanSum(int target, int[] array, Dictionary<int, bool> memo, List<int> path)
        {
            if (memo.ContainsKey(target))
            {
                if (memo[target] == true)
                    path.Add(target);
                return memo[target];
            }   

            if (target < 0)
                return false;

            if (target < array[^1])
            {
                memo[target] = false;
                return false;
            }

            foreach(int num in array)
            {
                if (target < num)
                    continue;
                int remainderTarget = target - num;
                bool canSum = CanSum(remainderTarget, array, memo, path);
                memo[remainderTarget] = canSum;
                if (canSum)
                {
                    path.Add(num);
                    return true;
                }
                    
            }
            memo[target] = false;
            return false;
        }

        public static void Test()
        {
            int[] array = new int[] { 2, 3, 5 };
            int target = 8;
            int[] sumPath = CanSum(target, array);
            if (sumPath.Length == 0)
                Console.WriteLine("No combination present");
            Console.WriteLine($"{target} = {System.Text.Json.JsonSerializer.Serialize(sumPath)}");
        }
    }
}
