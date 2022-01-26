using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class BinaryTreeTests
    {
        [TestMethod]
        public void SymmetricTestCase_1()
        {
            TreeNode rootNode = new(1);
            rootNode.Left = new(2);
            rootNode.Right = new(2);

            BinaryTree tree = new(rootNode);
            Assert.IsTrue(tree.IsSymmetric());
        }

        [TestMethod]
        public void SymmetricTestCase_2()
        {
            TreeNode rootNode = new(4);
            rootNode.Left = new(5);
            rootNode.Right = new(5);

            rootNode.Left.Left = new(2);
            rootNode.Left.Right = new(8);

            rootNode.Right.Left = new(8);
            rootNode.Right.Right = new(2);

            rootNode.Left.Left.Left = new(9);
            rootNode.Left.Left.Right = new(7);

            rootNode.Left.Right.Left = new(1);

            rootNode.Right.Right.Left = new(7);
            rootNode.Right.Right.Right = new(9);

            rootNode.Right.Left.Right = new(1);

            BinaryTree tree = new(rootNode);
            Assert.IsTrue(tree.IsSymmetric());
        }

        [TestMethod]
        public void SymmetricTestCase_3()
        {
            TreeNode rootNode = new(4);
            rootNode.Left = new(5);
            rootNode.Right = new(5);

            rootNode.Left.Left = new(2);
            rootNode.Left.Right = new(8);

            rootNode.Right.Left = new(8);
            rootNode.Right.Right = new(2);

            rootNode.Left.Left.Left = new(9);
            rootNode.Left.Left.Right = new(7);

            rootNode.Left.Right.Left = new(1);

            rootNode.Right.Right.Left = new(7);
            rootNode.Right.Right.Right = new(9);

            rootNode.Right.Left.Right = new(6);

            BinaryTree tree = new(rootNode);
            Assert.IsFalse(tree.IsSymmetric());
        }
    }
}
