using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgo
{
    public class Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            Dictionary<int, bool> numberHash = new();

            foreach (int num in nums)
            {
                if (!numberHash.ContainsKey(num))
                {
                    numberHash.Add(num, false);
                }
            }

            int longestSubsequence = 0;
            foreach (int num in nums)
            {
                bool isVisited = numberHash[num];
                if (isVisited)
                    continue;

                numberHash[num] = true;
                int currentSubsequenceLength = 1;
                int incrementalSequence = num + 1;

                while (numberHash.ContainsKey(incrementalSequence))
                {
                    numberHash[incrementalSequence] = true;
                    currentSubsequenceLength++;
                    incrementalSequence++;
                }

                int decrementalSequence = num - 1;
                while (numberHash.ContainsKey(decrementalSequence))
                {
                    numberHash[decrementalSequence] = true;
                    currentSubsequenceLength++;
                    decrementalSequence--;
                }

                if (currentSubsequenceLength > longestSubsequence)
                    longestSubsequence = currentSubsequenceLength;

            }
            return longestSubsequence;
        }
    }
}
