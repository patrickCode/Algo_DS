using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralAlgoTests
{
    [TestClass]
    public class KClosestNeighboursTests
    {
        [TestMethod]
        public void TestCase1_ElementInArray()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            KClosestElement arr = new(array);
            int[] closestElements = arr.GetClosestElements(4, 3);

            Assert.AreEqual(4, closestElements.Length);
            Assert.IsTrue(closestElements.ToList().Contains(1));
            Assert.IsTrue(closestElements.ToList().Contains(2));
            Assert.IsTrue(closestElements.ToList().Contains(3));
            Assert.IsTrue(closestElements.ToList().Contains(4));
        }

        [TestMethod]
        public void TestCase1_ElementNotInArray()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            KClosestElement arr = new(array);
            int[] closestElements = arr.GetClosestElements(4, -1);

            Assert.AreEqual(4, closestElements.Length);
            Assert.IsTrue(closestElements.ToList().Contains(1));
            Assert.IsTrue(closestElements.ToList().Contains(2));
            Assert.IsTrue(closestElements.ToList().Contains(3));
            Assert.IsTrue(closestElements.ToList().Contains(4));
        }
    }
}
