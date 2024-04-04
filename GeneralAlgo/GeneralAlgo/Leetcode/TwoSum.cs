// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
// https://leetcode.com/submissions/detail/1202916923/

public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int lowPointer = 0;
        int highPointer = numbers.Length - 1;

        while (lowPointer < highPointer)
        {
            int sum = numbers[lowPointer] + numbers[highPointer];
            if (sum == target)
            {
                return new int[] { lowPointer + 1, highPointer + 1 };
            }

            if (sum > target)
            {
                highPointer--;
                continue;
            }
            lowPointer++;
        }
        return null;
    }
}