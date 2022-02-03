using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgoTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void TestCase1_QuickSort()
        {
            int[] array = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            Sort sort = new(array);
            sort.QuickSort();
            Assert.AreEqual(10, sort.Array[0]);
            Assert.AreEqual(30, sort.Array[1]);
            Assert.AreEqual(40, sort.Array[2]);
            Assert.AreEqual(90, sort.Array[6]);
        }
    }
}
