using BinarySeachTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Tests
{
    [TestClass]
    public class TreeNodeTests
    {
        [TestMethod]
        public void Should_Create_3_Node_Tree()
        {
            var values = new int?[] { 1, 2, 3 };
            var root = new TreeNode(values);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.IsNull(root.left.left);
            Assert.IsNull(root.left.right);
            Assert.IsNull(root.right.left);
            Assert.IsNull(root.right.right);
        }

        [TestMethod]
        public void Should_Create_3_Node_Tree_Recurssion()
        {
            var values = new int?[] { 1, 2, 3 };
            var root = TreeNode.CreateTreeNode(values, 0);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.IsNull(root.left.left);
            Assert.IsNull(root.left.right);
            Assert.IsNull(root.right.left);
            Assert.IsNull(root.right.right);
        }

        [TestMethod]
        public void Should_Create_7_Node_Complete_Tree()
        {
            var values = new int?[] { 1, 2, 3, 4, 5, 6, 7 };
            var root = new TreeNode(values);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.AreEqual(root.left.left.val, 4);
            Assert.AreEqual(root.left.right.val, 5);
            Assert.AreEqual(root.right.left.val, 6);
            Assert.AreEqual(root.right.right.val, 7);
        }

        [TestMethod]
        public void Should_Create_7_Node_Complete_Tree_Recursion()
        {
            var values = new int?[] { 1, 2, 3, 4, 5, 6, 7 };
            var root = new TreeNode(values);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.AreEqual(root.left.left.val, 4);
            Assert.AreEqual(root.left.right.val, 5);
            Assert.AreEqual(root.right.left.val, 6);
            Assert.AreEqual(root.right.right.val, 7);
        }

        [TestMethod]
        public void Should_Create_7_Node_InComplete_Tree()
        {
            var values = new int?[] { 3, 1, 4, null, 2, 6, 7 };
            var root = TreeNode.CreateTreeNode(values, 0);

            Assert.AreEqual(root.val, 3);
            Assert.AreEqual(root.left.val, 1);
            Assert.AreEqual(root.right.val, 4);
            Assert.IsNull(root.left.left);
            Assert.AreEqual(root.left.right.val, 2);
            Assert.AreEqual(root.right.left.val, 6);
            Assert.AreEqual(root.right.right.val, 7);
        }

        [TestMethod]
        public void Should_Create_7_Node_InComplete_Tree_Recurssion()
        {
            var values = new int?[] { 3, 1, 4, null, 2, 6, 7 };
            var root = TreeNode.CreateTreeNode(values, 0);

            Assert.AreEqual(root.val, 3);
            Assert.AreEqual(root.left.val, 1);
            Assert.AreEqual(root.right.val, 4);
            Assert.IsNull(root.left.left);
            Assert.AreEqual(root.left.right.val, 2);
            Assert.AreEqual(root.right.left.val, 6);
            Assert.AreEqual(root.right.right.val, 7);
        }

        [TestMethod]
        public void Should_Create_10_Node_InComplete_Tree()
        {
            var values = new int?[] { 1, 2, 3, null, 4, 5, 6, null, null, null, null, null, null, 7, 8 };
            var root = new TreeNode(values);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.IsNull(root.left.left);
            Assert.AreEqual(root.left.right.val, 4);
            Assert.AreEqual(root.right.left.val, 5);
            Assert.AreEqual(root.right.right.val, 6);
            Assert.IsNull(root.left.right.left);
            Assert.IsNull(root.left.right.right);
            Assert.IsNull(root.right.left.left);
            Assert.IsNull(root.right.left.right);
            Assert.AreEqual(root.right.right.left.val, 7);
            Assert.AreEqual(root.right.right.right.val, 8);
        }

        [TestMethod]
        public void Should_Create_10_Node_InComplete_Tree_Recurssion()
        {
            var values = new int?[] { 1, 2, 3, null, 4, 5, 6, null, null, null, null, null, null, 7, 8 };
            var root = TreeNode.CreateTreeNode(values, 0);

            Assert.AreEqual(root.val, 1);
            Assert.AreEqual(root.left.val, 2);
            Assert.AreEqual(root.right.val, 3);
            Assert.IsNull(root.left.left);
            Assert.AreEqual(root.left.right.val, 4);
            Assert.AreEqual(root.right.left.val, 5);
            Assert.AreEqual(root.right.right.val, 6);
            Assert.IsNull(root.left.right.left);
            Assert.IsNull(root.left.right.right);
            Assert.IsNull(root.right.left.left);
            Assert.IsNull(root.right.left.right);
            Assert.AreEqual(root.right.right.left.val, 7);
            Assert.AreEqual(root.right.right.right.val, 8);
        }
    }
}
