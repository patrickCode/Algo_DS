using System;

namespace LinkLists
{
    public class RotateDoubleLinkList
    {
        public static void Start(string list, int rotationPoint)
        {
            var head = new DoubleNode(list);
            Console.Write($"Original List: ");
            head.Print();
            var rotatedList = Rotate(head, rotationPoint);
            Console.Write($"Rotated List: ");
            rotatedList.Print();
        }

        public static DoubleNode Rotate(DoubleNode head, int p)
        {
            DoubleNode start = head;
            DoubleNode end = null;
            DoubleNode last = head;
            int counter = 1;
            while (last.Next != null)
            {
                if (counter == p)
                {
                    end = last;
                }
                counter++;
                last = last.Next;
            }
            if (end != null)
            {
                DoubleNode nextStart = end.Next;
                end.Next = null;
                nextStart.Prev = null;
                last.Next = start;
                start.Prev = last;
                return nextStart;
            }
            return head;
        }
    }
}
