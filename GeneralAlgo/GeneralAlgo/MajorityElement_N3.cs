using System;
using System.Collections.Generic;
using System.Text;

// https://www.youtube.com/watch?v=Eua-UrQ_ANo
// Find all elements in an array that occur for more than n/3 times

namespace GeneralAlgo
{
    internal class MajorityElement_N3
    {
        public int[] FindMajorityElements(int[] array)
        {
            if (array.Length <= 2)
                return array;

            var (majorityElementCandidate1, majorityElementCandidate1_Votes) = GetNextMajorityElementCandidateWithCount(array, 0);
            var (majorityElementCandidate2, majorityElementCandidate2_Votes) = GetNextMajorityElementCandidateWithCount(array, (0 + majorityElementCandidate1_Votes));
            // Console.WriteLine($"Initial candidate: {majorityElementCandidate1} / {majorityElementCandidate2}");
            int startingIndex = majorityElementCandidate1_Votes + majorityElementCandidate2_Votes;
            for (int index = startingIndex; index < array.Length; index++)
            {
                int currentNumber = array[index];
                if (currentNumber == majorityElementCandidate1)
                {
                    majorityElementCandidate1_Votes++;
                    continue;
                }
                if (currentNumber == majorityElementCandidate2)
                {
                    majorityElementCandidate2_Votes++;
                    continue;
                }
                majorityElementCandidate1_Votes--;
                majorityElementCandidate2_Votes--;

                if (majorityElementCandidate1_Votes == majorityElementCandidate2_Votes
                    && majorityElementCandidate1_Votes == 0)
                {
                    // Reset
                    (majorityElementCandidate1, majorityElementCandidate1_Votes) = GetNextMajorityElementCandidateWithCount(array, index);
                    (majorityElementCandidate2, majorityElementCandidate2_Votes) = GetNextMajorityElementCandidateWithCount(array, index + majorityElementCandidate1_Votes);
                    index += majorityElementCandidate1_Votes + majorityElementCandidate1_Votes - 1;
                    continue;
                }

                if (majorityElementCandidate1_Votes < 0)
                {
                    (majorityElementCandidate1, majorityElementCandidate1_Votes) = GetNextMajorityElementCandidateWithCount(array, index);
                    index += majorityElementCandidate1_Votes - 1;
                }

                if (majorityElementCandidate2_Votes < 0)
                {
                    (majorityElementCandidate2, majorityElementCandidate2_Votes) = GetNextMajorityElementCandidateWithCount(array, index + majorityElementCandidate1_Votes);
                    index += majorityElementCandidate2_Votes - 1;
                }
            }

            return ValidateAndGetMajorityElements(array, majorityElementCandidate1, majorityElementCandidate2);
        }

        private Tuple<int?, int> GetNextMajorityElementCandidateWithCount(int[] array, int startFrom)
        {
            if (startFrom >= array.Length)
                return new Tuple<int?, int>(null, 0);

            int candidate = array[startFrom];
            int count = 1;
            int index = startFrom + 1;
            while (index < array.Length && array[index] == candidate)
            {
                count++;
                index++;
            }
            return new Tuple<int?, int>(candidate, count);
        }

        private int[] ValidateAndGetMajorityElements(int[] array, int? candidate_1, int? candidate_2)
        {
            int count_1 = 0;
            int count_2 = 0;

            foreach (int num in array)
            {
                if (num == candidate_1)
                    count_1++;
                if (num == candidate_2)
                    count_2++;
            }

            List<int> result = new();
            if (candidate_1 != null && count_1 > (array.Length / 3))
                result.Add(candidate_1.Value);
            if (candidate_2 != null && count_2 > (array.Length / 3))
                result.Add(candidate_2.Value);

            return result.ToArray();
        }
    }
}
