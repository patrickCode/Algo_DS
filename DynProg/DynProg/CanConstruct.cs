using System;
using System.Linq;
using System.Collections.Generic;

namespace DynProg
{
    // Given a string and an array of strings, find out if any combination of the strings in the array (repetitions allowed) can create the word
    internal static class StringDP
    {
        // m - target length
        // n - phrases length
        // Height of tree - m (worst case - we branch for every single phrase)
        // Branching factor - n (Worst case - all phrases match the target)
        // Time - O(n^m * additional calculation) - Here additional calculation is O(m) - iterating the string for substring
        // Time - (m * n ^ m)
        // Space - Height of tree + New string creted - O(m) + O(m) = O(m)
        public static bool CanConstruct(string target, string[] phrases) 
        {
            if (string.IsNullOrWhiteSpace(target))
                return true;

            foreach(string prefixPhrases in phrases.Where(phrase => target.StartsWith(phrase)))
            {
                string remainingTarget = target[prefixPhrases.Length..]; //The string is iterated, in a worst case O(m)
                bool canConstruct = CanConstruct(remainingTarget, phrases);
                if (canConstruct)
                    return true;
            }
            return false;
        }

        // Time - O(n * m^2)
        //  - m --> We need to go through each memo entry (max m entries)
        //  - m --> Substring worst case
        //  - n loops
        // Space - O(m^2) - memo length * substring
        public static bool CanConstruct(string target, string[] phrases, Dictionary<string, bool> memo)
        {
            if (string.IsNullOrWhiteSpace(target))
                return true;

            if (memo.ContainsKey(target))
                return memo[target];

            foreach (string prefixPhrases in phrases.Where(phrase => target.StartsWith(phrase)))
            {
                string remainingTarget = target[prefixPhrases.Length..];
                bool canConstruct = CanConstruct(remainingTarget, phrases);
                memo.Add(remainingTarget, canConstruct);
                if (canConstruct)
                    return true;
            }
            return false;
        }

        // Time - O(n^m * additional calculation) - Here additional calculation is O(m) - iterating the string for substring
        // Time - (m * n ^ m)
        public static int CountConstruct(string target, string[] phrases)
        {
            if (string.IsNullOrWhiteSpace(target))
                return 1;

            int totalCount = 0;
            foreach (string prefixPhrases in phrases.Where(phrase => target.StartsWith(phrase)))
            {
                string remainingTarget = target[prefixPhrases.Length..];
                int remainingCount = CountConstruct(remainingTarget, phrases);
                totalCount += remainingCount;
            }
            return totalCount;
        }

        // Time - O(n * m^2)
        // Space - O(m^2) - memo length * substring
        public static int CountConstruct(string target, string[] phrases, Dictionary<string, int> memo)
        {
            if (string.IsNullOrWhiteSpace(target))
                return 1;

            if (memo.ContainsKey(target))
                return memo[target];

            int totalCount = 0;
            foreach (string prefixPhrases in phrases.Where(phrase => target.StartsWith(phrase)))
            {
                string remainingTarget = target[prefixPhrases.Length..];
                int remainingCount = CountConstruct(remainingTarget, phrases);
                totalCount += remainingCount;
            }
            memo.Add(target, totalCount);
            return totalCount;
        }

        public static void Test()
        {
            // Can Construct recursion
            //Console.WriteLine(CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));
            //Console.WriteLine(CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));

            // Can Construct DP
            //Console.WriteLine(CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, new()));
            //Console.WriteLine(CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }, new()));

            // Count construct recursion
            //Console.WriteLine(CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }));
            //Console.WriteLine(CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));

            // Count construct DP
            Console.WriteLine(CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl" }, new()));
            Console.WriteLine(CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }, new()));
        }
    }
}
