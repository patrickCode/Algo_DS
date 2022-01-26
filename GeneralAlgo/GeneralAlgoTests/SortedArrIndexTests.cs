using System;
using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class SortedArrIndexTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7 };
            Tuple<int, int> expected = new Tuple<int, int>(4, 7);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 5));
        }

        [TestMethod]
        public void TestCase_2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7 };
            Tuple<int, int> expected = new Tuple<int, int>(0, 0);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 1));
        }

        [TestMethod]
        public void TestCase_3()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7 };
            Tuple<int, int> expected = new Tuple<int, int>(9, 9);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 7));
        }

        [TestMethod]
        public void TestCase_4()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 6, 7 };
            Tuple<int, int> expected = new Tuple<int, int>(-1, -1);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 8));
        }

        [TestMethod]
        public void TestCase_5()
        {
            int[] arr = new int[] { 5, 5, 5, 5, 6, 7 };
            Tuple<int, int> expected = new Tuple<int, int>(0, 3);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 5));
        }

        [TestMethod]
        public void TestCase_6()
        {
            int[] arr = new int[] { 1, 2, 4, 5, 5, 5 };
            Tuple<int, int> expected = new Tuple<int, int>(3, 5);
            Assert.AreEqual(expected, SortedArrIndex.FindIndex(arr, 5));
        }
    }
}
