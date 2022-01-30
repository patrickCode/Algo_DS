using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralAlgoTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        public void TestCase1_Spiral_3X3()
        {
            int[,] _3dmatrix = new int[3, 3]
            {
                { 1, 2, 3 },
                { 8, 9, 4 },
                { 7, 6, 5 }
            };

            Matrix matrix = new(_3dmatrix);

            List<int> spiral = matrix.Spiral().ToList();
            for (int i = 1; i <= 9; i++)
            {
                Assert.AreEqual(i, spiral[i - 1]);
            }
        }

        [TestMethod]
        public void TestCase1_Spiral_3X4()
        {
            int[,] _3dmatrix = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 10, 11, 12, 5 },
                { 9, 8, 7, 6 }
            };

            Matrix matrix = new(_3dmatrix);

            List<int> spiral = matrix.Spiral().ToList();
            for (int i = 1; i <= 12; i++)
            {
                Assert.AreEqual(i, spiral[i - 1]);
            }
        }
    }
}
