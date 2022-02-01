using BinaryTrees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTests
{
    [TestClass]
    public class NumericalBinaryTreeTests
    {
        [TestMethod]
        public void TestCase1_3NodeTree_AllPostive()
        {
            Node<int> node1 = new(1);
            Node<int> node2 = new(2);
            Node<int> node3 = new(3);
            node1.Left = node2;
            node2.Right = node3;

            NumericalBinaryTree tree = new(node1);
            int maxPathSum = tree.CalcMaxPathSum();

            Assert.AreEqual(6, maxPathSum);
        }

        [TestMethod]
        public void TestCase1_3NodeTree_WithNegativesPostive()
        {
            Node<int> node1 = new(1);
            Node<int> node2 = new(-2);
            Node<int> node3 = new(-3);
            node1.Left = node2;
            node1.Right = node3;

            NumericalBinaryTree tree = new(node1);
            int maxPathSum = tree.CalcMaxPathSum();

            Assert.AreEqual(1, maxPathSum);
        }

        [TestMethod]
        public void TestCase1_3NodeTree_WithNegativesPostive_ZigZag()
        {
            Node<int> node1 = new(1);
            Node<int> node2 = new(-2);
            Node<int> node3 = new(-3);
            node1.Left = node2;
            node2.Right = node3;

            NumericalBinaryTree tree = new(node1);
            int maxPathSum = tree.CalcMaxPathSum();

            Assert.AreEqual(1, maxPathSum);
        }

        [TestMethod]
        public void TestCase1_5NodeTree_AllPostive()
        {
            Node<int> node1 = new(1);
            Node<int> node2 = new(2);
            Node<int> node3 = new(3);
            Node<int> node4 = new(4);
            Node<int> node5 = new(5);
            node3.Left = node4;
            node3.Right = node5;
            node1.Left = node2;
            node1.Right = node3;
            

            NumericalBinaryTree tree = new(node1);
            int maxPathSum = tree.CalcMaxPathSum();

            Assert.AreEqual(12, maxPathSum);
        }
    }
}