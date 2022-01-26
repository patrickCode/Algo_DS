namespace GeneralAlgo
{
    public class BinaryTree
    {
        public TreeNode Root { get; }

        public BinaryTree(TreeNode root)
        {
            Root = root;
        }

        public bool IsSymmetric()
        {
            return IsSymmetric(Root, Root);
        }

        private static bool IsSymmetric(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null)
                return true;

            if (node1 == null || node2 == null)
                return false;

            if (node1.Value != node2.Value)
                return false;

            return IsSymmetric(node1.Left, node2.Right) && IsSymmetric(node1.Right, node2.Left);
        }
    }
}
