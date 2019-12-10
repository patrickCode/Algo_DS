using System;
using System.Linq;

namespace LinkLists
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }

        public Node(string numbers)
        {
            CreateListFromString(numbers);
        }

        public void Print()
        {
            var iterator = this;
            while (iterator != null)
            {
                Console.Write(iterator.data + " ");
                iterator = iterator.next;
            }
            Console.WriteLine();
        }

        private void CreateListFromString(string numbers)
        {
            var numbersArray = numbers.Split(' ').Select(numberStr => int.Parse(numberStr)).ToList();
            data = numbersArray[0];
            Node currentNode = this;

            for (int iterator = 1; iterator < numbersArray.Count; iterator++)
            {
                var node = new Node(numbersArray[iterator]);
                currentNode.next = node;
                currentNode = currentNode.next;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Node otherNode))
                return false;
            if (data == otherNode.data && next == null && otherNode.next == null)
                return true;
            if (data == otherNode.data && next.Equals(otherNode))
                return true;
            return false;
        }
    }
}
