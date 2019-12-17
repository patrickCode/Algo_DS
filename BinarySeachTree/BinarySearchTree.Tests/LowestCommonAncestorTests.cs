using BinarySeachTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTree.Tests
{
    [TestClass]
    public class LowestCommonAncestorTests
    {
        [TestMethod]
        public void ShouldFind_LCA_AtRoot()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(2);
            var q = new TreeNode(8);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(6, lca.val);
        }

        [TestMethod]
        public void ShouldFind_LCA_AtRight()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(7);
            var q = new TreeNode(9);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(8, lca.val);
        }

        [TestMethod]
        public void ShouldFind_LCA_AtRight_Root()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(8);
            var q = new TreeNode(9);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(8, lca.val);
        }

        [TestMethod]
        public void ShouldFind_LCA_AtLeft_SingleLevel()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(0);
            var q = new TreeNode(4);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(2, lca.val);
        }

        [TestMethod]
        public void ShouldFind_LCA_AtLeft_SecondLevel()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(3);
            var q = new TreeNode(5);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(4, lca.val);
        }

        [TestMethod]
        public void ShouldFind_LCA_AtLeft_FirstAndSecondLevel()
        {
            var nodes = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            var tree = new TreeNode(nodes);

            var p = new TreeNode(0);
            var q = new TreeNode(5);

            var lca = LowestCommonAncestor.FindLowestCommonAncestor(tree, p, q);
            Assert.AreEqual(2, lca.val);
        }
    }
}
