using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class KBiggestElementTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            int[] arr = new int[] { 4, 2, 9, 7, 5, 6, 7, 1, 3 };
            int k = 4;
            Assert.AreEqual(6, KBiggestElement.FindBiggestElement(arr, k));
        }
    }
}
