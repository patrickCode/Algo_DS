using BinarySeachTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Tests
{
    [TestClass]
    public class KthSmallestElementTests
    {
        [TestMethod]
        public void Find_LowestElement()
        {
            var nodes = new int?[] { 3, 1, 4, null, 2 };
            var tree = new TreeNode(nodes);

            var kthSmallest = KthSmallestElement.Find(tree, 1);
            Assert.AreEqual(1, kthSmallest);
        }

        [TestMethod]
        public void Find_Second_LowestElement()
        {
            var nodes = new int?[] { 3, 1, 4, null, 2 };
            var tree = new TreeNode(nodes);

            var kthSmallest = KthSmallestElement.Find(tree, 2);
            Assert.AreEqual(2, kthSmallest);
        }

        [TestMethod]
        public void Find_Third_LowestElement()
        {
            var nodes = new int?[] { 5, 3, 6, 2, 4, null, null, 1 };
            var tree = TreeNode.CreateTreeNode(nodes, 0);

            var kthSmallest = KthSmallestElement.Find(tree, 3);
            Assert.AreEqual(3, kthSmallest);
        }

        [TestMethod]
        public void Find_HighestElement()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 13, null, null, 3, 5 };
            var tree = TreeNode.CreateTreeNode(nodes, 0);

            var kthSmallest = KthSmallestElement.Find(tree, 9);
            Assert.AreEqual(13, kthSmallest);
        }
    }
}
