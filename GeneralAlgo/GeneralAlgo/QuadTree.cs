using System;

namespace GeneralAlgo
{
    public class QuadNode
    {
        public int Value { get; private set; }
        public bool IsLeaf { get; private set; }
        public QuadNode TopLeftNode { get; private set; }
        public QuadNode TopRightNode { get; private set; }
        public QuadNode BottomRightNode { get; private set; }
        public QuadNode BottonLeftNode { get; private set; }

        public QuadNode(int value, bool isLeaf)
        {
            Value = value;
            IsLeaf = isLeaf;
        }

        public void SetChildNodes(QuadNode topLeft, QuadNode topRight, QuadNode bottomRight, QuadNode bottomLeft)
        {
            TopLeftNode = topLeft;
            TopRightNode = topRight;
            BottomRightNode = bottomRight;
            BottonLeftNode = bottomLeft;
        }
    }

    public class QuadTree
    {
        public QuadNode Root { get; private set; }
        public int Size { get; private set; }

        public QuadTree(int[,] grid)
        {
            ValidateGrid(grid);
            Size = grid.GetLength(0);
            Construct(grid);
        }

        private void ValidateGrid(int[,] grid)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            if (rows != cols)
            {
                throw new Exception("Invalid grid: Grid must be a square to form quad tree");
            }
            bool isPowerOf2 = rows != 0 && ((rows & (rows - 1)) == 0);
            if (!isPowerOf2)
            {
                throw new Exception("Invalid grid: Grid size must be a square of 2");
            }
        }

        private void Construct(int[,] grid)
        {
            Root = CreateNode(grid, origin: new(0, 0), quadSize: Size);
        }

        private QuadNode CreateNode(int[,] grid, Tuple<int, int> origin, int quadSize)
        {
            var (originRow, originCol) = origin;
            if (IsLeafNode(grid, origin, quadSize))
            {
                return new QuadNode(grid[originRow, originCol], isLeaf: true);
            }

            QuadNode node = new (grid[originRow, originCol], isLeaf: false);
            int childNodeQuadSize = quadSize / 2;
            node.SetChildNodes(
                topLeft: CreateNode(grid, new(originRow, originCol), childNodeQuadSize),
                topRight: CreateNode(grid, new(originRow, originCol + childNodeQuadSize), childNodeQuadSize),
                bottomRight: CreateNode(grid, new(originRow + childNodeQuadSize, originCol + childNodeQuadSize), childNodeQuadSize),
                bottomLeft: CreateNode(grid, new(originRow + childNodeQuadSize, originCol), childNodeQuadSize));
            return node;
        }

        private bool IsLeafNode(int[,] grid, Tuple<int, int> origin, int quadSize)
        {
            if (quadSize == 1)
            {
                return true;
            }
            return AreAllValuesSameInQuad(grid, origin, quadSize);
        }

        private bool AreAllValuesSameInQuad(int[,] grid, Tuple<int, int> origin, int quadSize)
        {
            var (originRow, originCol) = origin;
            int value = grid[originRow, originCol];
            for (int row = originRow; row < originRow + quadSize; row++)
            {
                for (int col = originCol; col < originCol + quadSize; col++)
                {
                    if (grid[row, col] != value)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
