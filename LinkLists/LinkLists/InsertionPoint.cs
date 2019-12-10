namespace LinkLists
{
    /*
     * https://practice.geeksforgeeks.org/problems/intersection-point-in-y-shapped-linked-lists/
     * Get the larger list and traverse it till the difference. Then traverse both the lists until a common node is found.
     */
    public class InsertionPoint
    {
        public int IntersectPoint(Node headA, Node headB)
        {
            int lengthA = 0;
            Node startA = headA;
            while (startA != null)
            {
                startA = startA.next;
                lengthA++;
            }

            int lengthB = 0;
            Node startB = headB;
            while (startB != null)
            {
                startB = startB.next;
                lengthB++;
            }

            Node largerList = lengthA >= lengthB ? headA : headB;
            Node smallerList = lengthA >= lengthB ? headB : headA;

            int diff = lengthA >= lengthB ? lengthB - lengthA : lengthA - lengthB;
            for (int iterator = 1; iterator <= diff; iterator++)
                largerList = largerList.next;

            while (smallerList != null && !largerList.Equals(smallerList))
            {
                largerList = largerList.next;
                smallerList = smallerList.next;
            }
            if (smallerList == null)
                return -1;
            return smallerList.data;
        }
    }
}
