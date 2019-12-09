using System;
using System.Linq;

namespace LinkLists
{
    public class DoubleNode
    {
        public int Data;
        public DoubleNode Prev, Next;

        public DoubleNode(int data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }

        public DoubleNode(string numbers)
        {
            CreateListFromString(numbers);
        }

        public void Print()
        {
            var iterator = this;
            while (iterator != null)
            {
                Console.Write(iterator.Data + " ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }

        private void CreateListFromString(string numbers)
        {
            var numbersArray = numbers.Split(' ').Select(numberStr => int.Parse(numberStr)).ToList();
            Data = numbersArray[0];
            DoubleNode currentNode = this;

            for (int iterator = 1; iterator < numbersArray.Count; iterator++)
            {
                var node = new DoubleNode(numbersArray[iterator]);
                currentNode.Next = node;
                node.Prev = currentNode;
                currentNode = currentNode.Next;
            }
        }
    }
}
