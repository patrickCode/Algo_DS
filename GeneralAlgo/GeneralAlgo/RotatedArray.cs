namespace GeneralAlgo
{   
    public class RotatedArray
    {
        private readonly int[] _array;

        public RotatedArray(int[] array)
        {
            _array = array;
        }

        // Problem: https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
        // Reference: https://www.youtube.com/watch?v=nIVW4P8b1VA
        public int Min()
        {
            int low = 0, mid;
            int high = _array.Length - 1;
            
            while (low < high)
            {
                mid = (low + high) / 2;
                if (_array[low] < _array[high])
                    return _array[low];

                if (_array[mid] >= _array[low])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return _array[low];
        }
    }
}
