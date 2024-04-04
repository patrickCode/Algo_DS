using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgo
{
    internal class NextLargestPallindrome
    {
        public int Get(int number)
        {
            if (number < 0) return -1;
            if (number < 10) return number;

            short[] digits = ConvertToDigitsArray(number);
            int leftPointer = 0;
            int rightPointer = digits.Length - 1;

            while (leftPointer < rightPointer)
            {
                // Case 1 - Left Side is same as right side
                while (digits[leftPointer] == digits[rightPointer] && leftPointer < rightPointer)
                {
                    leftPointer++;
                    rightPointer--;
                    continue;
                }

                // Case 2 - Left side is bigger than right side
                while (digits[leftPointer] > digits[rightPointer] && leftPointer < rightPointer)
                {
                    digits[rightPointer--] = digits[leftPointer++];
                    continue;
                }

                // Case 3 - Left side is smaller than right side (Disbalanced)
                if (digits[leftPointer] < digits[rightPointer])
                {
                    int midLeftPointer = digits.Length % 2 == 0 ? (digits.Length / 2) - 1 : digits.Length / 2;
                    int midRightPointer = digits.Length / 2;

                    if (digits[midLeftPointer] < 9)
                    {
                        digits[midLeftPointer]++;
                        digits[midRightPointer] = digits[midLeftPointer];
                    }
                    else
                    {
                        digits[midLeftPointer] = 0;
                        digits[midRightPointer] = 0;
                        int leftCarryOverPointer = midLeftPointer - 1;
                        while (leftCarryOverPointer > leftPointer && digits[leftCarryOverPointer] == 9)
                        {
                            digits[leftCarryOverPointer--] = 0;
                        }
                        digits[leftCarryOverPointer]++;
                    }

                    while (rightPointer > midRightPointer && leftPointer < midLeftPointer)
                    {   
                        digits[rightPointer--] = digits[leftPointer++];
                    }
                    break;
                }
            }

            return ConvertDigitsArrayToNumber(digits);
        }

        private short[] ConvertToDigitsArray(int number)
        {
            int temp = number;
            int digitCounter = 0;
            while (temp > 0)
            {
                temp /= 10;
                digitCounter++;
            }

            short[] digits = new short[digitCounter];
            temp = number;
            while (temp > 0)
            {
                digits[--digitCounter] = (short)(temp % 10);
                temp /= 10;
            }
            return digits;
        }

        private int ConvertDigitsArrayToNumber(short[] digits)
        {
            int number = 0;
            for (int dIdx = digits.Length - 1; dIdx >= 0; dIdx--)
            {
                number = (number * 10) + digits[dIdx];
            }
            return number;
        }
    }
}
