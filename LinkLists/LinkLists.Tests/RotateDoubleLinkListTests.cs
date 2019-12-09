using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkLists.Tests
{
    [TestClass]
    public class RotateDoubleLinkListTests
    {
        [TestMethod]
        public void Rotate_At_2()
        {
            var list = "1 2 3 4 5 6";
            var node = new DoubleNode(list);
            var rotatedNode = RotateDoubleLinkList.Rotate(node, 2);

            Assert.AreEqual(3, rotatedNode.Data);
            Assert.AreEqual(4, rotatedNode.Next.Data);
            Assert.AreEqual(5, rotatedNode.Next.Next.Data);
            Assert.AreEqual(6, rotatedNode.Next.Next.Next.Data);
            Assert.AreEqual(1, rotatedNode.Next.Next.Next.Next.Data);
            Assert.AreEqual(2, rotatedNode.Next.Next.Next.Next.Next.Data);
        }

        [TestMethod]
        public void Rotate_At_0()
        {
            var list = "1 2 3 4 5 6";
            var node = new DoubleNode(list);
            var rotatedNode = RotateDoubleLinkList.Rotate(node, 0);

            Assert.AreEqual(1, rotatedNode.Data);
            Assert.AreEqual(2, rotatedNode.Next.Data);
            Assert.AreEqual(3, rotatedNode.Next.Next.Data);
            Assert.AreEqual(4, rotatedNode.Next.Next.Next.Data);
            Assert.AreEqual(5, rotatedNode.Next.Next.Next.Next.Data);
            Assert.AreEqual(6, rotatedNode.Next.Next.Next.Next.Next.Data);
        }
    }
}
