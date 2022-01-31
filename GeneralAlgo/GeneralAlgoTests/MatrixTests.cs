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

        [TestMethod]
        public void TestCase2_Rotate_2X2()
        {
            int[,] _2darray = new int[2, 2]
            {
                { 1, 2 },
                { 3, 4 }
            };

            int[,] rotated = new int[2, 2]
            {
                { 3, 1 },
                { 4, 2 }
            };

            Matrix matrix = new(_2darray);
            matrix.Rotate();

            for(int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Assert.AreEqual(rotated[row, col], matrix.GetMatrix()[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestCase2_Rotate_3X3()
        {
            int[,] _2darray = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] rotated = new int[3, 3]
            {
                { 7, 4, 1 },
                { 8, 5, 2 },
                { 9, 6, 3 }
            };

            Matrix matrix = new(_2darray);
            matrix.Rotate();

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Assert.AreEqual(rotated[row, col], matrix.GetMatrix()[row, col]);
                }
            }
        }

        [TestMethod]
        public void TestCase2_Rotate_4X4()
        {
            int[,] _2darray = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            int[,] rotated = new int[4, 4]
            {
                { 13, 9, 5, 1 },
                { 14, 10, 6, 2 },
                { 15, 11, 7, 3 },
                { 16, 12, 8, 4 }
            };

            Matrix matrix = new(_2darray);
            matrix.Rotate();

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Assert.AreEqual(rotated[row, col], matrix.GetMatrix()[row, col]);
                }
            }
        }
    }
}
