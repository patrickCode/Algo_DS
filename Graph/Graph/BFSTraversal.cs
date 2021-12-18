using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    internal class BFSTraversal
    {
        public static void Run()
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
            Traverse(graph, source);
        }

        public static void Traverse(Dictionary<int, List<int>> graph, int startNode)
        {
            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            while (queue.Any())
            {
                int node = queue.Dequeue();
                Console.WriteLine(node);
                List<int> neighbours = graph[node];

                foreach(int neighbour in neighbours)
                {
                    queue.Enqueue(neighbour);
                }
            }
        }
    }
}
