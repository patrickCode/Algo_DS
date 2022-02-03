namespace GeneralAlgo
{
    public class Sort
    {
        public int[] Array { get; private set; }

        public Sort(int[] array)
        {
            Array = array;
        }

        public void QuickSort()
        {
            QuickSort(0, Array.Length - 1);
        }

        private void QuickSort(int start, int end)
        {
            if (start >= end)
                return;

            int pivotIndex = end;
            int lowPointer = start - 1;
            int highPointer = start;

            while (highPointer < end)
            {
                if (Array[highPointer] >= Array[pivotIndex])
                {
                    highPointer++;
                    continue;
                }

                lowPointer++;
                Swap(lowPointer, highPointer);
                highPointer++;
            }
            Swap(lowPointer + 1, pivotIndex);
            QuickSort(start, lowPointer);
            QuickSort(lowPointer + 2, pivotIndex);
        }

        private void Swap(int pointer1, int pointr2)
        {
            (Array[pointr2], Array[pointer1]) = (Array[pointer1], Array[pointr2]);
        }
    }
}
