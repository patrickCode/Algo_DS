using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GeneralAlgo
{
    public class Matrix
    {
        private readonly int[,] _matrix;

        private const int RIGHT = 0;
        private const int DOWN = 1;
        private const int LEFT = 2;
        private const int UP = 3;

        public Matrix(int[,] matrix)
        {
            _matrix = matrix;
        }

        public IEnumerable<int> Spiral()
        {
            int rows = _matrix.GetLength(0);
            int cols = _matrix.GetLength(1);

            List<Tuple<int, int>> directions = new()
            {
                new Tuple<int, int>(0, 1), // Right
                new Tuple<int, int>(1, 0), // Down
                new Tuple<int, int>(0, -1), // Left
                new Tuple<int, int>(-1, 0), // Up
            };
            int currentDirection = RIGHT;

            int horizontalPaces = currentDirection == RIGHT || currentDirection == LEFT ? cols : cols - 1;
            int verticalPaces = currentDirection == UP || currentDirection == DOWN ? rows : rows - 1;

            Tuple<int, int> position = new(0, 0);
            int distanceTravelled = 0;

            while (horizontalPaces > 0 || verticalPaces > 0)
            {
                var (row, col) = position;
                yield return _matrix[row, col];

                distanceTravelled++;
                bool hasReachedEnd;
                if (currentDirection == RIGHT || currentDirection == LEFT)
                {
                    hasReachedEnd = distanceTravelled >= horizontalPaces;
                    if (hasReachedEnd)
                    {
                        currentDirection = (currentDirection + 1) % directions.Count;
                        distanceTravelled = 0;
                        horizontalPaces--;
                        if (verticalPaces == 0)
                            break;
                    }
                }
                else
                {
                    hasReachedEnd = distanceTravelled >= verticalPaces;
                    if (hasReachedEnd)
                    {
                        currentDirection = (currentDirection + 1) % directions.Count;
                        distanceTravelled = 0;
                        verticalPaces--;
                        if (horizontalPaces == 0)
                            break;
                    }
                }

                row += directions[currentDirection].Item1;
                col += directions[currentDirection].Item2;
                position = new(row, col);
            }
        }
    }
}
