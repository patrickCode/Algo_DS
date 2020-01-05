namespace StringAlgo
{
    /*
     * LeetCode
     * https://www.youtube.com/watch?v=UulHAjxjZ4o
     * Find if a string is a substring of another string
     * Time - O(n)
     * Space - O(n)
     */
    public class Subsequence
    {
        public static bool IsSubsequence(string source, string target)
        {
            if (string.IsNullOrWhiteSpace(source))
                return true;

            var sourceIndex = 0;
            for(var targetIndex = 0; targetIndex < target.Length; targetIndex++)
            {
                if (source[sourceIndex] == target[targetIndex])
                    sourceIndex++;
                if (sourceIndex == source.Length)
                    return true;
            }
            return false;
        }
    }
}
