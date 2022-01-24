using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    internal static class ShortestPath
    {
        public static int GetShortestPath(List<KeyValuePair<char, char>> edges, char source, char destination)
        {
            Dictionary<char, List<char>> graph = UndirectedHasPath.BuildGraph(edges);
            Queue<KeyValuePair<char, int>> processQueue = new();
            HashSet<char> visited = new();

            processQueue.Enqueue(new(source, 0));
            int shortestDistance = int.MaxValue;
            while (processQueue.Any())
            {
                var (currentNode, currentDistance) = processQueue.Dequeue();
                if (currentNode == destination)
                {
                    if (currentDistance < shortestDistance)
                        shortestDistance = currentDistance;
                }   

                if (visited.Contains(currentNode))
                    continue;

                
                foreach(char neighbour in graph[currentNode])
                {
                    processQueue.Enqueue(new(neighbour, currentDistance + 1));
                }
                visited.Add(currentNode);
            }

            return shortestDistance;
        }

        public static void Test()
        {
            List<KeyValuePair<char, char>> edges = new()
            {
                new('w', 'x'),
                new('x', 'y'),
                new('z', 'y'),
                new('z', 'v'),
                new('w', 'v')
            };

            int shortestPath = GetShortestPath(edges, 'w', 'z');
            if (shortestPath < int.MaxValue)
                Console.WriteLine($"Shortest path is {shortestPath}");
            else
                Console.WriteLine($"There is no path");
        }
    }
}
