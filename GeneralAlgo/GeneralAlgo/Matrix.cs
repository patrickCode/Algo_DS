using System;
using System.Collections.Generic;

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

        public void Rotate()
        {
            int rows = _matrix.GetLength(0);
            int cols = _matrix.GetLength(1);
            if (rows != cols)
                return;
            Rotate(new(0, rows - 1, 0, cols - 1));
        }

        public int[,] GetMatrix()
        {
            return _matrix;
        }

        private void Rotate(Tuple<int, int, int, int> boundaries)
        {
            var (left, right, up, down) = boundaries;
            int boundaryWidth = right - left + 1;
            if (boundaryWidth == 1 || boundaryWidth == 0)
                return;

            List<int> row_lr = new();
            for (int index = left; index <= right; index++)
            {
                row_lr.Add(_matrix[up, index]);
            }

            List<int> col_ud = new();
            for (int index = up; index <= down; index++)
            {
                col_ud.Add(_matrix[index, right]);
            }

            List<int> row_rl = new();
            for (int index = right; index >= left; index--)
            {
                row_rl.Add(_matrix[down, index]);
            }

            List<int> col_du = new();
            for (int index = down; index >= up; index--)
            {
                col_du.Add(_matrix[index, left]);
            }

            // LR --> UD
            int counter = 0;
            for (int index = up; index <= down; index++)
            {
                _matrix[index, right] = row_lr[counter++];
            }

            // UD --> RL
            counter = 0;
            for (int index = right; index >= left; index--)
            {
                _matrix[down, index] = col_ud[counter++];
            }

            // RL --> DU
            counter = 0;
            for (int index = down; index >= up; index--)
            {
                _matrix[index, left] = row_rl[counter++];
            }

            // DU --> LR
            counter = 0;
            for (int index = left; index <= right; index++)
            {
                _matrix[up, index] = col_du[counter++];
            }

            Rotate(new(left + 1, right - 1, up + 1, down - 1));
        }
    }
}
