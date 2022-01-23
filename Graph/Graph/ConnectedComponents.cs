using System.Linq;
using System.Collections.Generic;
using System;

namespace Graph
{
    internal class ConnectedComponents
    {
        public static int GetConnectedComponents(Dictionary<int, List<int>> graph)
        {
            HashSet<int> visited = new();
            int connectedComponents = 0;
            foreach (int node in graph.Keys)
            {
                if (visited.Contains(node))
                    continue;

                DFS(graph, node, visited);
                connectedComponents++;
            }
            return connectedComponents;
        }

        private static void DFS(Dictionary<int, List<int>> graph, int startNode, HashSet<int> visited)
        {
            if (!graph.ContainsKey(startNode))
                return;

            Stack<int> nodeStack = new();
            nodeStack.Push(startNode);

            while (nodeStack.Any())
            {
                int currentNode = nodeStack.Pop();
                if (visited.Contains(currentNode))
                    continue;
                List<int> neighbours = graph[currentNode];
                foreach (int neighbor in neighbours)
                {
                    nodeStack.Push(neighbor);
                }
                visited.Add(currentNode);
            }
        }

        public static void Test()
        {
            Dictionary<int, List<int>> graph = new()
            {
                {
                    0,
                    new() { 8, 1, 5 }
                },
                {
                    1,
                    new() { 0 }
                },
                {
                    5,
                    new() { 0, 8 }
                },
                {
                    8,
                    new() { 0, 5 }
                },
                {
                    2,
                    new() { 3, 4 }
                },
                {
                    3,
                    new() { 2, 4 }
                },
                {
                    4,
                    new() { 3, 2 }
                }
            };

            int connectedComponents = GetConnectedComponents(graph);
            Console.WriteLine($"There are {connectedComponents} connected components");
        }
    }
}
