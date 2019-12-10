namespace LinkLists
{
    public class DeleteWithoutHead
    {
        /*
         * Swap each value and delete the node
         * https://practice.geeksforgeeks.org/problems/delete-without-head-pointer/1
         */
        public void Delete(Node node)
        {
            if (node.next == null)
            {
                node.data = 0;
                node = null;
            }
                

            Node prev = null;
            while (node.next != null)
            {
                prev = node;
                node = node.next;
                prev.data = node.data;
            }
            prev.next = null;
        }
    }
}
