using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class UglyNumberTests
    {
        [TestMethod]
        public void IsUgnlyNum_8_True()
        {
            Assert.IsTrue(UglyNumber.IsUgly(8));
        }

        [TestMethod]
        public void IsUgnlyNum_6_True()
        {
            Assert.IsTrue(UglyNumber.IsUgly(6));
        }

        [TestMethod]
        public void IsUgnlyNum_20_True()
        {
            Assert.IsTrue(UglyNumber.IsUgly(20));
        }

        [TestMethod]
        public void IsUgnlyNum_14_False()
        {
            Assert.IsFalse(UglyNumber.IsUgly(14));
        }
    }
}
