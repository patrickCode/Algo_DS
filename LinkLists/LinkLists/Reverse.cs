namespace LinkLists
{   
    public class Reverse
    {
        // Reference: https://www.youtube.com/watch?v=RF_M9tX4Eag
        public void ReverseList(Node root, int start, int end)
        {
            Node reversedListRoot = null;
            Node reversedListTail = null;

            Node temp = root;
            Node reversePoint = temp;
            while (temp != null && temp.data != start)
            {
                reversePoint = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            reversedListTail = temp;
            bool endLoop = false;
            while (temp != null)
            {
                if (reversedListRoot == null)
                {
                    reversedListRoot = temp;
                    temp = temp.next;
                    reversedListRoot.next = null;
                }
                else
                {
                    Node previousRevRoot = reversedListRoot;
                    reversedListRoot = temp;
                    temp = temp.next;
                    reversedListRoot.next = previousRevRoot;
                }

                if (endLoop)
                    break;
                endLoop = temp.data == end;
            }

            if (temp != null)
                reversedListTail.next = temp;
            reversePoint.next = reversedListRoot;
        }
    }
}
