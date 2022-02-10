using System;
using System.Collections.Generic;

namespace Graph
{
    internal class Island
    {
        private readonly int[,] _graph;
        private readonly int _row;
        private readonly int _col;

        public Island(int[,] graph)
        {
            _graph = graph;
            _row = graph.GetLength(0);
            _col = graph.GetLength(1);
        }

        public int Count()
        {
            HashSet<string> visitedNodes = new();
            int islandCounter = 0;

            for(int rIndex = 0; rIndex < _row; rIndex++)
            {
                for (int cIndex = 0; cIndex < _col; cIndex++)
                {
                    if (_graph[rIndex , cIndex] == 1)
                    {
                        if (visitedNodes.Contains(GetNodePos(rIndex, cIndex)))
                        {
                            continue;
                        }
                        islandCounter++;
                        Explore(rIndex, cIndex, visitedNodes);
                    }
                }
            }
            return islandCounter;
        }

        private void Explore(int row, int col, HashSet<string> visited)
        {
            bool isRowInbound = row >= 0 && row < _row;
            bool isColInbound = col >= 0 && col < _col;

            if (!isRowInbound || !isColInbound)
                return;

            string nodePos = GetNodePos(row, col);
            
            if (_graph[row, col] == 0)
                return;

            if (visited.Contains(nodePos))
                return;
            visited.Add(nodePos);

            Explore(row - 1, col, visited);
            Explore(row, col + 1, visited);
            Explore(row + 1, col, visited);
            Explore(row, col - 1, visited);
        }

        public string GetNodePos(int row, int col)
        {
            return $"{row},{col}";
        }

        public static void Test()
        {
            int[,] graph = new int[,]
            {
                {0, 1, 0, 0, 0},
                {0, 1, 0, 0, 0},
                {0, 0, 0, 1, 0},
                {1, 0, 0, 1, 1},
                {1, 1, 0, 0, 0}
            };

            Island island = new(graph);
            int islandCount = island.Count();

            Console.WriteLine($"There are {islandCount} islands in the grid");
        }
    }
}
