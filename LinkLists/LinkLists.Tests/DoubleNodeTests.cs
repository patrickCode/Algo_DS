using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkLists.Tests
{
    [TestClass]
    public class DoubleNodeTests
    {
        [TestMethod]
        public void Should_Create_From_String()
        {
            var list = "1 2 3 4 5 6";
            var node = new DoubleNode(list);

            Assert.IsNotNull(node);
            Assert.AreEqual(1, node.Data);
            Assert.AreEqual(2, node.Next.Data);
            Assert.AreEqual(3, node.Next.Next.Data);
            Assert.AreEqual(4, node.Next.Next.Next.Data);
            Assert.AreEqual(5, node.Next.Next.Next.Next.Data);
            Assert.AreEqual(6, node.Next.Next.Next.Next.Next.Data);
            Assert.AreEqual(5, node.Next.Next.Next.Next.Next.Prev.Data);
            Assert.AreEqual(4, node.Next.Next.Next.Next.Next.Prev.Prev.Data);
            Assert.AreEqual(3, node.Next.Next.Next.Next.Next.Prev.Prev.Prev.Data);
            Assert.AreEqual(2, node.Next.Next.Next.Next.Next.Prev.Prev.Prev.Prev.Data);
            Assert.AreEqual(1, node.Next.Next.Next.Next.Next.Prev.Prev.Prev.Prev.Prev.Data);
        }
    }
}
