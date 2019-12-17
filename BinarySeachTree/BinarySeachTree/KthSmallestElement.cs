namespace BinarySeachTree
{
    /*
     * https://www.youtube.com/watch?v=C6r1fDKAW_o
     * https://practice.geeksforgeeks.org/problems/find-k-th-smallest-element-in-bst/1
     */
    public static class KthSmallestElement
    {
        private static int currentCount = 1;
        private static int? result = null;
        public static int Find(TreeNode root, int k)
        {
            currentCount = 1;
            result = null;
            PartialInorder(root, k);
            return result.Value;
        }

        private static void PartialInorder(TreeNode root, int k)
        {
            if (result != null)
                return;
            if (root == null)
                return;

            PartialInorder(root.left, k);
            if (currentCount == k)
            {
                result = root.val;
            }
            currentCount++;
            PartialInorder(root.right, k);
        }
    }
}
