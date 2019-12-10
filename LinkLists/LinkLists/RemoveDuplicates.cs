using System;
using System.Collections.Generic;
using System.Text;

namespace LinkLists
{
    public class RemoveDuplicates
    {
        public Node Remove(Node root)
        {
            Node start = root.next;
            Node prev = root;
            while (start != null)
            {
                if (start.data == prev.data)
                {
                    prev.next = start.next;
                    start = prev.next;
                }
                else
                {
                    prev = prev.next;
                    start = start.next;
                }
            }
            return root;
        }
    }
}
