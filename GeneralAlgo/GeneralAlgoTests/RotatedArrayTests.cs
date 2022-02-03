using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class RotatedArrayTests
    {
        [TestMethod]
        public void TestCase1_FindMin_Rot2()
        {
            int[] array = new int[] { 3, 4, 5, 1, 2 };
            RotatedArray rArr = new(array);
            int min = rArr.Min();
            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestCase1_FindMin_Rot0()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            RotatedArray rArr = new(array);
            int min = rArr.Min();
            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestCase1_FindMin_Rot6()
        {
            int[] array = new int[] { 6, 7, 0, 1, 2, 4, 5 };
            RotatedArray rArr = new(array);
            int min = rArr.Min();
            Assert.AreEqual(0, min);
        }
    }
}
