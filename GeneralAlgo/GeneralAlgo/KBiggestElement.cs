namespace GeneralAlgo
{
    public static class KBiggestElement
    {
        public static int FindBiggestElement(int[] arr, int k)
        {
            if (k > arr.Length)
                return -1;
            PriorityQueue queue = new(arr);
            int element = -1;
            for (int i = 1; i <= k; i++)
            {
                element = queue.Pop();
            }
            return element;
        }
    }
}
