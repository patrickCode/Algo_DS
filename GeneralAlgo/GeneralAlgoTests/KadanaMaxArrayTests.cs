using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class KadanaMaxArrayTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            int[] array = new int[] { -2, 3, 2, -1 };
            int expectedMaxSubArray = 5;
            Assert.AreEqual(expectedMaxSubArray, KadaneMaxSubArray.MaxSubArray(array));
        }

        [TestMethod]
        public void TestCase_2()
        {
            int[] array = new int[] { 1, -3, 2, 1, -1 };
            int expectedMaxSubArray = 3;
            Assert.AreEqual(expectedMaxSubArray, KadaneMaxSubArray.MaxSubArray(array));
        }
    }
}
