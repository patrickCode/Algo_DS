namespace LinkLists
{
    public class Palindrome
    {
        /*
         * https://practice.geeksforgeeks.org/problems/check-if-linked-list-is-pallindrome/1/
         * Reverse the linked list and check for palindrome
         * Alternate - Create a stack and push n/2 nodes. Then start the iteration and keep popping numbers from the stack
         */
        public bool IsPalindrome(Node head)
        {
            Node rev = new Node(head.data);
            Node start = head.next;
            while (start != null)
            {
                Node temp = new Node(start.data);
                temp.next = rev;
                rev = temp;
                start = start.next;
            }

            start = head;
            while (start != null)
            {
                if (start.data != rev.data)
                    return false;
                start = start.next;
                rev = rev.next;
            }

            return true;
        }
    }
}
