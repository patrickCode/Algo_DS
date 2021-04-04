using System;

namespace DynProg
{
    // Given a 2D grid where you can travel only right or down. Starting from top-left, how many ways can you travel to bottom-right
    public static class GridTraveller
    {
        public static long GetWays(int rowCount, int colCount)
        {
            if (rowCount < 0 || colCount < 0)
                return -1;

            long[,] grid = new long[rowCount, colCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    if (row == 0 || col == 0)
                    {
                        grid[row, col] = 1;
                        continue;
                    }
                    long waysToTravelFromTop = grid[row - 1, col];
                    long waysToTravelFromLeft = grid[row, col - 1];
                    long waysToTravel = waysToTravelFromTop + waysToTravelFromLeft;
                    grid[row, col] = waysToTravel;
                }
            }

            return grid[rowCount - 1, colCount - 1];
        }

        public static void Test()
        {
            int row = 18;
            int col = 18;

            Console.WriteLine($"For a grid of size ({row}, {col}) number of ways to travel: {GetWays(row, col)}");
        }
    }
}
