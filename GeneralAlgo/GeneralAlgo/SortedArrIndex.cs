using System;

namespace GeneralAlgo
{
    public static class SortedArrIndex
    {
        public static Tuple<int, int> FindIndex(int[] arr, int target)
        {
            int firstIndex = FindFirstIndex(arr, target);
            if (firstIndex == -1)
                return new Tuple<int, int>(-1, -1);
            int lastIndex = FindLastIndex(arr, target);
            return new Tuple<int, int>(firstIndex, lastIndex);
        }

        private static int FindFirstIndex(int[] arr, int target)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = (first + last) / 2;

            while (first <= last)
            {
                if (arr[mid] == target && (mid == 0 || arr[mid - 1] < target))
                    return mid;

                if (arr[mid] >= target)
                    last = mid - 1;
                else
                    first = mid + 1;

                mid = (first + last) / 2;
            }
            return -1;
        }

        private static int FindLastIndex(int[] arr, int target)
        {
            int first = 0;
            int last = arr.Length - 1;
            int mid = (first + last) / 2;

            while (first <= last)
            {
                if (arr[mid] == target && (mid == arr.Length - 1 || arr[mid + 1] > target))
                    return mid;

                if (arr[mid] > target)
                    last = mid - 1;
                else
                    first = mid + 1;

                mid = (first + last) / 2;
            }
            return -1;
        }
    }
}
