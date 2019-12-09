using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkLists.Tests
{
    [TestClass]
    public class NodeTests
    {
        [TestMethod]
        public void Should_Get_Created()
        {
            var list = "1 2 3 4 5 6";
            var node = new Node(list);

            Assert.IsNotNull(node);
            Assert.AreEqual(1, node.data);
            Assert.AreEqual(2, node.next.data);
            Assert.AreEqual(3, node.next.next.data);
            Assert.AreEqual(4, node.next.next.next.data);
            Assert.AreEqual(5, node.next.next.next.next.data);
            Assert.AreEqual(6, node.next.next.next.next.next.data);
        }
    }
}
