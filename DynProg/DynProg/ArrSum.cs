using System;
using System.Collections.Generic;

namespace DynProg
{
    // Given a target sum and an array of positive numbers, find out if any combination of numbers from the array (repetition allowed) sums up to the target
    // Prob 2 (Best Sum) - Find the best combination
    // Time: O(m * n)
    // Space: O(m)
    public class ArrSum
    {
        public static List<int> BestSum_Rec(int target, int[] array)
        {
            if (target == 0) return new List<int>();
            if (target < 0) return null;

            List<int> shortestPath = null;
            foreach(int num in array)
            {
                int remainderTarget = target - num;
                List<int> remainderPath = BestSum_Rec(remainderTarget, array);
                if (remainderPath != null)
                {
                    remainderPath.Add(num);
                    if (shortestPath == null || remainderPath.Count < shortestPath.Count)
                    {
                        shortestPath = remainderPath;
                    }
                }
            }

            return shortestPath;
        }

        public static List<int> BestSum(int target, int[] array)
        {
            if (target == 0) return new List<int>();
            if (target < 0) return null;

            Dictionary<int, List<int>> memoizedPaths = new();
            foreach (int num in array)
            {
                memoizedPaths.Add(num, new List<int> { num });
            }
            memoizedPaths.Add(0, new List<int>());
            List<int> shortestPath = BestSum(target, array, memoizedPaths);
            return shortestPath;
        }

        private static List<int> BestSum(int target, int[] array, Dictionary<int, List<int>> memoizedPath)
        {
            if (memoizedPath.ContainsKey(target))
                return memoizedPath[target];

            if (target < 0) return null;

            List<int> shortestPath = null;

            foreach (int num in array)
            {
                int remainderTarget = target - num;
                List<int> remainderPath = BestSum(remainderTarget, array, memoizedPath);
                if (remainderPath != null)
                {
                    remainderPath.Add(num);
                    if (shortestPath == null || remainderPath.Count < shortestPath.Count)
                    {
                        shortestPath = remainderPath;
                    }
                }
            }
            memoizedPath.Add(target, shortestPath);
            return shortestPath;
        }

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
            List<int> path = new();
            bool canSum = CanSum(target, array, memo, path);
            if (canSum)
                return path.ToArray();
            return Array.Empty<int>();
        }

        /*
         * Create a memo dict object with all elements of the array
         * Every number in the array (dict) can contribute to the summation
         * For each number in the array
         * * Check what's the remainder target needed from the array if you take this number
         * * Recur the same problem, with all the elements in the array but for the remainder target
         * * Keep recurring until you get 0 (i.e. the target has been reached) or remainder is negative (i.e. target cannot be reached)
         * For improving performance, maintain a dictionary of numbers and just keep track if this target sum has already been processed, this will ensure that the same target sum is not processed multiple times
         */
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

            foreach (int num in array)
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
            int[] array = new int[] { 1, 4, 5 };
            int target = 8;
            // int[] sumPath = CanSum(target, array);
            //int[] sumPath = BestSum_Rec(target, array)?.ToArray();
            int[] sumPath = BestSum(target, array)?.ToArray();
            if (sumPath == null || sumPath.Length == 0)
                Console.WriteLine("No combination present");
            Console.WriteLine($"{target} = {System.Text.Json.JsonSerializer.Serialize(sumPath)}");
        }
    }
}
