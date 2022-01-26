using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class PriorityQueueTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            int[] arr = new int[] { 4, 2, 9, 7, 6, 7, 1, 3 };
            PriorityQueue queue = new(arr);

            Assert.AreEqual(9, queue.Pop());
            Assert.AreEqual(7, queue.Pop());
            Assert.AreEqual(7, queue.Pop());
            Assert.AreEqual(6, queue.Pop());
        }
    }
}
