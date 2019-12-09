using System;
using System.Collections.Generic;
using System.Text;

namespace LinkLists
{
    public class MoveZeros
    {
        public static void Start(string list)
        {
            var head = new Node(list);
            Console.Write($"Original List: ");
            head.Print();
            var rotatedList = Move(head);
            Console.Write($"Moved List: ");
            rotatedList.Print();
        }

        public static Node Move(Node head)
        {
            Node start = head;
            while (start.data == 0 && start != null)
            {
                start = start.next;
            }
            Node prev = start;
            if (start != null)
            {
                start = start.next;
            }

            Node newHead = head;
            while (start != null)
            {
                if (start.data == 0)
                {
                    prev.next = start.next;
                    newHead = start;
                    start = start.next;
                    newHead.next = head;
                    head = newHead;
                }
                else
                {
                    prev = start;
                    start = start.next;
                }
            }
            return newHead;
        }
    }
}
