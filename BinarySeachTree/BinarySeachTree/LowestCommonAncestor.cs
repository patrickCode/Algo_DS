namespace BinarySeachTree
{
    /*
     * https://www.youtube.com/watch?v=kulWKd3BUcI
     * https://practice.geeksforgeeks.org/problems/lowest-common-ancestor-in-a-bst/1
     * Exp - For each node starting from the Root check if the 2 nodes are on either side of the current node. If so then return the current node, else go to the RST or LST based on if the nodes are smaller or larger
     */
    public class LowestCommonAncestor
    {
        public static TreeNode FindLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (p.val < root.val && q.val < root.val)
                return FindLowestCommonAncestor(root.left, p, q);
            if (p.val > root.val && q.val > root.val)
                return FindLowestCommonAncestor(root.right, p, q);
            return root;
        }
    }
}
