using System;
using System.Linq;
using System.Collections.Generic;

namespace Graph
{
    internal class DFSTraversal
    {
        public static void Run(bool useRecursion = false)
        {
            var graph = new Dictionary<int, List<int>>()
            {
                { 1, new List<int> { 2, 3 } },
                { 2, new List<int> { 4 } },
                { 3, new List<int> { 5 } },
                { 4, new List<int> { 6 } },
                { 5, new List<int>() },
                { 6, new List<int>() }
            };

            int source = 1;

            if (useRecursion)
                TraverseRecurse(graph, source);
            else
                Traverse(graph, source);
        }

        private static void Traverse(Dictionary<int, List<int>> graph, int startingNode)
        {
            var nodes = new Stack<int>();
            nodes.Push(startingNode);
            while (nodes.Any())
            {
                int current = nodes.Pop();
                Console.WriteLine(current);

                List<int> neighbours = graph[current];
                foreach (int neighbour in neighbours)
                {
                    nodes.Push(neighbour);
                }
            }
        }

        private static void TraverseRecurse(Dictionary<int, List<int>> graph, int startingNode)
        {
            Console.WriteLine(startingNode);
            List<int> neighbours = graph[startingNode];
            foreach (int neighbour in neighbours)
            {
                TraverseRecurse(graph, neighbour);
            }
        }
    }
}
