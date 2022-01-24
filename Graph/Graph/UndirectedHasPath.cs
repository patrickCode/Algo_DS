using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    internal static class UndirectedHasPath
    {
        public static bool HasPath(List<KeyValuePair<char, char>> edges, char nodeA, char nodeB)
        {
            Stack<char> nodesStack = new();
            HashSet<char> visited = new();
            Dictionary<char, List<char>> graph = BuildGraph(edges);

            nodesStack.Push(nodeA);
            while (nodesStack.Any())
            {
                char currentNode = nodesStack.Pop();
                if (currentNode == nodeB)
                    return true;

                if (!graph.ContainsKey(currentNode))
                    continue;

                List<char> neighbours = graph[currentNode];
                visited.Add(currentNode);

                foreach(char neighbor in neighbours)
                {
                    if (visited.Contains(neighbor))
                        continue;

                    visited.Add(neighbor);
                    nodesStack.Push(neighbor);
                }
            }
            return false;
        }

        public static Dictionary<char, List<char>> BuildGraph(List<KeyValuePair<char, char>> edges)
        {
            Dictionary<char, List<char>> graph = new();
            foreach(KeyValuePair<char, char> edge in edges)
            {
                if (graph.ContainsKey(edge.Key))
                    graph[edge.Key].Add(edge.Value);
                else
                    graph.Add(edge.Key, new List<char>() { edge.Value });

                if (graph.ContainsKey(edge.Value))
                    graph[edge.Value].Add(edge.Key);
                else
                    graph.Add(edge.Value, new List<char>() { edge.Key });
            }
            return graph;
        }

        public static void Test()
        {
            List<KeyValuePair<char, char>> edgeList = new()
            {
                new('i', 'j'),
                new('k', 'i'),
                new('m', 'k'),
                new('k', 'l'),
                new('o', 'n')
            };
            bool hasPath = HasPath(edgeList, 'i', 'n');
            if (hasPath)
                Console.WriteLine("Path exsist");
            else
                Console.WriteLine("Path doesn't exsist");
        }
    }
}
