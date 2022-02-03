using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkLists.Tests
{
    [TestClass]
    public class ReverseTests
    {
        [TestMethod]
        public void TestCase1_ReverseList()
        {
            Node root = new(1);
            root.next = new(2);
            root.next.next = new(3);
            root.next.next.next = new(4);
            root.next.next.next.next = new(5);

            Reverse rev = new();
            rev.ReverseList(root, 2, 4);

            Assert.AreEqual(1, root.data);
            Assert.AreEqual(4, root.next.data);
            Assert.AreEqual(3, root.next.next.data);
            Assert.AreEqual(2, root.next.next.next.data);
            Assert.AreEqual(5, root.next.next.next.next.data);
        }
    }
}
