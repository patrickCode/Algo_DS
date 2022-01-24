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

        public static int GetLargestConnectedComponentSize(Dictionary<int, List<int>> graph)
        {
            HashSet<int> visited = new();
            int largestComponent = 0;
            foreach (int node in graph.Keys)
            {
                if (visited.Contains(node))
                    continue;

                int componentSize = DFS(graph, node, visited);
                if (componentSize > largestComponent)
                    largestComponent = componentSize;
            }
            return largestComponent;
        }

        private static int DFS(Dictionary<int, List<int>> graph, int startNode, HashSet<int> visited)
        {
            if (!graph.ContainsKey(startNode))
                return 0;

            Stack<int> nodeStack = new();
            nodeStack.Push(startNode);
            int graphSize = 0;

            while (nodeStack.Any())
            {
                int currentNode = nodeStack.Pop();
                if (visited.Contains(currentNode))
                    continue;
                
                graphSize++;
                List<int> neighbours = graph[currentNode];
                foreach (int neighbor in neighbours)
                {
                    nodeStack.Push(neighbor);
                }
                visited.Add(currentNode);
            }
            return graphSize;
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
            int largestComponent = GetLargestConnectedComponentSize(graph);
            Console.WriteLine($"There are {connectedComponents} connected components and the largest component is {largestComponent}");
        }
    }
}
