using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    // https://structy.net/problems/has-path
    // Time - O(e) - In the worst case we will need to travel all the edges. In the worst cast a graph with n nodes can have n^2 edges so time complexity is O(n^2)
    // Space - O(n)
    internal class Path
    {
        public static void Run()
        {
            var graph = new Dictionary<int, List<int>>()
            {
                { 6, new List<int> { 7, 9 } },
                { 7, new List<int> { 8 } },
                { 8, new List<int>() },
                { 9, new List<int> { 7, 11 } },
                { 10, new List<int>() { 9 } },
                { 11, new List<int>() }
            };

            int source = 6;
            int destination = 11;

            bool hasPath = HasPath(graph, source, destination);
            Console.WriteLine(hasPath ? "Path exists" : "Path does not exist");
                
        }


        public static bool HasPath(Dictionary<int, List<int>> graph, int source, int destination)
        {
            if (source == destination)
                return true;

            List<int> neighbours = graph[source];
            foreach(int neighbour in neighbours)
            {
                if (HasPath(graph, neighbour, destination))
                    return true;
            }
            return false;
        }
    }
}
