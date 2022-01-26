using System;

namespace GeneralAlgo
{
    public class PriorityQueue
    {
        private int[] _heap;
        private int _heapSize;

        public PriorityQueue(int[] elements)
        {
            _heap = elements;
            _heapSize = _heap.Length;
            Heapification();
        }

        public int Pop()
        {
            Swap(0, _heapSize - 1);
            _heapSize--;
            Heapify(0);
            return _heap[_heapSize];
        }

        private void Heapification()
        {
            for (int index = _heapSize / 2; index >= 0; index--)
            {
                Heapify(index);
            }
        }

        public void Heapify(int index)
        {
            if (index >= _heapSize)
                return;

            int leftIndex = index * 2 + 1;
            int rightIndex = index * 2 + 2;

            int currentNode = _heap[index];
            int leftChild = leftIndex < _heapSize ? _heap[leftIndex] : -1;
            int rightChild = rightIndex < _heapSize ? _heap[rightIndex] : -1;

            int max = GetMax(currentNode, leftChild, rightChild);
            if (currentNode == max)
                return;

            if (leftChild == max)
            {
                Swap(index, leftIndex);
                Heapify(leftIndex);
                return;
            }
            Swap(index, rightIndex);
            Heapify(rightIndex);

        }

        private void Swap(int index1, int index2)
        {
            (_heap[index2], _heap[index1]) = (_heap[index1], _heap[index2]);
        }

        private int GetMax(int value1, int value2, int value3)
        {
            return Math.Max(Math.Max(value1, value2), value3);
        }
    }
}
