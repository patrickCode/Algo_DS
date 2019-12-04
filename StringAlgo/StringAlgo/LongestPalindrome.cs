using System;

namespace StringAlgo
{
    /*
     * Find the longest palindronme in a string
     */
    public class LongestPalindrome
    {
        public static void Start(string[] inputs)
        {
            foreach(var input in inputs)
            {
                var longestPalindrome = GetLongestPalindrome(input);
                Console.WriteLine($"{input} -> {longestPalindrome}");
            }
        }

        public static string GetLongestPalindrome(string sourceString)
        {
            var longestPalindrome = string.Empty;
            for(var center = 1; center < sourceString.Length - 1; center++)
            {
                var oddPalindromeAtCenter = GetPallindromeAtCenter(sourceString, center, checkForOddLength: true);
                var evenPalindromeAtCenter = GetPallindromeAtCenter(sourceString, center, checkForOddLength: false);

                longestPalindrome = longestPalindrome.Length > oddPalindromeAtCenter.Length
                    ? (longestPalindrome.Length > evenPalindromeAtCenter.Length ? longestPalindrome : evenPalindromeAtCenter)
                    : (oddPalindromeAtCenter.Length > evenPalindromeAtCenter.Length ? oddPalindromeAtCenter : evenPalindromeAtCenter);
            }
            return longestPalindrome;
        }

        private static string GetPallindromeAtCenter(string sourceString, int center, bool checkForOddLength)
        {   
            var start = checkForOddLength ? center - 1 : center;
            var end = center + 1;

            while (start >= 0 && end < sourceString.Length && sourceString[start] == sourceString[end])
            {
                start--;
                end++;
            }
            start++;
            end--;

            if (start == end)
                return "";
            return Substring(sourceString, start, end);
        }

        private static string Substring(string sourceString, int startIndex, int endIndex)
        {
            var subString = "";
            for(var iterator = startIndex; iterator <= endIndex; iterator++)
            {
                subString += sourceString[iterator];
            }
            return subString;
        }
    }
}
