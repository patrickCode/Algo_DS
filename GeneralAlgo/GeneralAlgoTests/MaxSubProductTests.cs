using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgoTests
{
    [TestClass]
    public class MaxSubProductTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            int[] array = new int[] { 2, 3, -2, 4 };
            int expectedMaxSubArray = 6;
            Assert.AreEqual(expectedMaxSubArray, MaxSubProduct.MaxProduct(array));
        }
    }
}
