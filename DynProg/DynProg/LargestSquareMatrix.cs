using System;

namespace DynProg
{
    public static class LargestSquareMatrix
    {
        public static int GetLargestSquareMatrix(int[,] matrix)
        {
            int length = (int)Math.Sqrt(matrix.Length);
            int[,] cache = new int[length + 1, length + 1];
            var globalMaxSquare = 0;
            for (int row = 0; row < length + 1; row++)
            {
                for (int col = 0; col < length + 1; col++)
                {
                    if (row == 0 || col == 0)
                    {
                        cache[row, col] = 0;
                        continue;
                    }

                    int cell = matrix[row - 1, col - 1];
                    int localMaxSquare = cell == 1
                        ? Math.Min(Math.Min(cache[row - 1, col - 1], cache[row - 1, col]), cache[row, col - 1]) + 1
                        : 0;
                    cache[row, col] = localMaxSquare;
                    globalMaxSquare = localMaxSquare > globalMaxSquare ? localMaxSquare : globalMaxSquare;
                }
            }
            return globalMaxSquare;
        }

        public static void Test()
        {
            int[,] matrix = new int[,]
            {
                { 0, 1, 0, 1, 1 },
                { 0, 1, 1, 1, 1 },
                { 0, 0, 1, 1, 1 },
                { 0, 0, 1, 1, 1 },
                { 0, 1, 1, 1, 1 }
            };

            //int[,] matrix = new int[,]
            //{
            //    { 1, 1, 1, 1, 1 },
            //    { 1, 1, 1, 1, 1 },
            //    { 1, 1, 1, 1, 1 },
            //    { 1, 1, 1, 1, 1 },
            //    { 1, 1, 1, 1, 1 }
            //};
            int maxSquare = GetLargestSquareMatrix(matrix);
            Console.WriteLine($"Max Square: {maxSquare}");
        }
    }
}
