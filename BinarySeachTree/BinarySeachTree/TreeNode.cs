using System.Collections.Generic;

namespace BinarySeachTree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val)
        {
            this.val = val;
        }

        public TreeNode(int?[] values)
        {
            var unprocessedNodes = new Queue<TreeNode>();
            val = values[0].Value;
            var currentRoot = this;
            for (int iterator = 0; iterator < values.Length - 2; iterator++)
            {
                if (values[iterator] == null)
                    continue;

                var leftIndex = 2 * iterator + 1;
                var rightIndex = 2 * iterator + 2;

                if (leftIndex >= values.Length)
                    break;

                if (values[leftIndex] != null)
                {
                    var leftNode = new TreeNode(values[leftIndex].Value);
                    currentRoot.left = leftNode;
                    unprocessedNodes.Enqueue(leftNode);
                }
                if (values[rightIndex] != null)
                {
                    var rightNode = new TreeNode(values[rightIndex].Value);
                    currentRoot.right = rightNode;
                    unprocessedNodes.Enqueue(rightNode);
                    currentRoot = unprocessedNodes.Dequeue();
                }
                if (values[leftIndex] == null && values[rightIndex] == null)
                {
                    if (unprocessedNodes.Count == 0)
                        break;
                    currentRoot = unprocessedNodes.Dequeue();
                }
            }
        }

        public static TreeNode CreateTreeNode(int?[] values, int index) 
        {
            if (index >= values.Length)
                return null;
            if (values[index] == null)
                return null;

            var node = new TreeNode(values[index].Value)
            {
                left = CreateTreeNode(values, index * 2 + 1),
                right = CreateTreeNode(values, index * 2 + 2)
            };
            return node;
        }
    }
}
