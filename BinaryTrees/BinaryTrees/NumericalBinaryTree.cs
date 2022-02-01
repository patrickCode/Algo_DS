namespace BinaryTrees
{
    public class NumericalBinaryTree
    {
        private readonly Node<int> _root;
        private int MaxPathSum;

        public const int MIN = -1000;

        public NumericalBinaryTree(Node<int> root)
        {
            _root = root;
            MaxPathSum = MIN;
        }

        /// <summary>
        /// Reference - https://www.youtube.com/watch?v=Hr5cWUld4vU
        /// </summary>
        /// <returns></returns>
        public int CalcMaxPathSum()
        {
            CalcMaxPathSum(_root);
            return MaxPathSum;
        }
        
        private int CalcMaxPathSum(Node<int> node)
        {
            if (node.IsLeaf())
            {
                if (node.Value > MaxPathSum)
                    MaxPathSum = node.Value;
                return node.Value;
            }


            int maxLeftSubTreeSum = node.Left != null
                ? CalcMaxPathSum(node.Left)
                : MIN;

            int maxRightSubTreeSum = node.Right != null
                ? CalcMaxPathSum(node.Right)
                : MIN;

            int maxPartialPathSum = Math.Max(
                node.Value,
                Math.Max(node.Value + maxLeftSubTreeSum, node.Value + maxRightSubTreeSum)
            );

            int maxPathSumWithCurrentRoot = Math.Max(maxPartialPathSum, node.Value + maxLeftSubTreeSum + maxRightSubTreeSum);
            if (maxPathSumWithCurrentRoot > MaxPathSum)
                MaxPathSum = maxPathSumWithCurrentRoot;

            return maxPartialPathSum;
        }
    }
}
