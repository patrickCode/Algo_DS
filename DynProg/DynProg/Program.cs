using System;
using System.Collections.Generic;

namespace DynProg
{
    class Program
    {
        static void Main(string[] args)
        {
            // LargestSquareMatrix.Test();
            // Fibonacci.Test();
            // GridTraveller.Test();
            // ArrSum.Test();
            // Knapsack.Test();
            // StringDP.Test();
            DictionaryTests();

            Console.ReadKey();


        }

        static void DictionaryTests()
        {
            Dictionary<int, List<int>> dic = new()
            {
                { 1, new List<int>() { 1 } },
                { 2, new List<int>() { 2 } },
                { 3, new List<int> { 1, 2, 3 } }
            };

            List<int> list = new List<int>() { 1, 2, 3, 4 };
            dic.Add(4, list);

            list.Add(5);

            foreach (KeyValuePair<int, List<int>> pair in dic)
            {
                string line = $"{pair.Key} {System.Text.Json.JsonSerializer.Serialize(pair.Value)}";
                Console.WriteLine(line);
            }
        }
    }
}
