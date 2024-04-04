using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralAlgo
{
    public class Sudoku
    {
        public int GRID_SIZE = 9;
        public bool IsValidSudoku(char[][] board)
        {
            return ValidateRows(board) && ValidateCols(board) && ValidateSquares(board);
        }
        private bool ValidateRows(char[][] board)
        {
            for (int row = 0; row < GRID_SIZE; row++)
            {
                if (!ValidateLine(board[row]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateCols(char[][] board)
        {
            for (int col = 0; col < GRID_SIZE; col++)
            {
                char[] column = new char[GRID_SIZE];
                for (int row = 0; row < GRID_SIZE; row++)
                {
                    column[row] = board[row][col];
                }
                if (!ValidateLine(column))
                    return false;
            }
            return true;
        }

        private bool ValidateSquares(char[][] board)
        {
            int squareSize = GRID_SIZE / 3;

            for (int squareIndex = 0; squareIndex < squareSize; squareIndex++)
            {
                int minRow = 0 + (squareIndex * 3);
                int maxRow = 2 + (squareIndex * 3);
                int minCol = 0 + (squareIndex * 3);
                int maxCol = 2 + (squareIndex * 3);

                char[] square = new char[9];
                int squareArrIndex = 0;
                for (int row = minRow; row <= maxRow; row++)
                {
                    for (int col = minCol; col <= maxCol; col++)
                    {
                        square[squareArrIndex++] = board[row][col];
                    }
                }
                if (!ValidateLine(square))
                    return false;
            }
            return true;
        }

        private bool ValidateLine(char[] line)
        {
            HashSet<char> digitTracker = new();

            foreach (char digit in line)
            {
                if (digit == '.')
                    continue;
                if (digitTracker.Contains(digit))
                    return false;
                digitTracker.Add(digit);
            }
            return true;
        }
    }
}
