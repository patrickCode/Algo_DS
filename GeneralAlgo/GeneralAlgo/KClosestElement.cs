using System.Collections.Generic;

namespace GeneralAlgo
{
    // Reference: https://www.youtube.com/watch?v=o-YDQzHoaKM
    // Problem: 
    public class KClosestElement
    {
        private readonly int[] _array;

        public KClosestElement(int[] array)
        {
            _array = array;
        }

        public int[] GetClosestElements(int k, int num)
        {
            int closestPosition = FindClosestPosition(num);
            List<int> closestNeighbours = new();
            int highNeighbour = closestPosition + 1;
            int lowNeighbour = closestPosition;

            while (k > 0 && (highNeighbour < _array.Length || lowNeighbour >= 0))
            {
                int distanceFromHighNeighbour = highNeighbour < _array.Length ? _array[highNeighbour] - num : int.MaxValue;
                int distanceFromLowNeighbour = lowNeighbour >= 0 ? num - _array[lowNeighbour] : int.MaxValue;

                if (distanceFromLowNeighbour <= distanceFromHighNeighbour)
                {
                    closestNeighbours.Add(_array[lowNeighbour]);
                    lowNeighbour--;
                    k--;
                    continue;
                }

                closestNeighbours.Add(_array[highNeighbour]);
                highNeighbour++;
                k--;
            }
            return closestNeighbours.ToArray();
        }

        private int FindClosestPosition(int num)
        {
            int low = 0, high = _array.Length - 1;
            int mid = (low + high) / 2;
            while (low < high)
            {
                if (_array[mid] == num)
                    break;

                if (_array[mid] < num)
                    low = mid + 1;
                else
                    high = mid - 1;

                mid = (low + high) / 2;
            }
            return mid;
        }
    }
}
