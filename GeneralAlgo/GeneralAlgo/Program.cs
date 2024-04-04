using System;
using System.Collections.Generic;

namespace GeneralAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrHash program = new();
            //int[] result = program.GetTopFrequent(new int[] { -1, -1 }, 1);
            //PrintArray(result);

            //Sudoku sudoku = new();
            //char[][] board = new char[][] {
            //    new char[] { '5','3','.','.','7','.','.','.','.' },
            //    new char[] { '6','.','.','1','9','5','.','.','.' },
            //    new char[] { '.','9','8','.','.','.','.','6','.' },
            //    new char[] { '8','.','.','.','6','.','.','.','3' },
            //    new char[] { '4','.','.','8','.','3','.','.','1' },
            //    new char[] { '7','.','.','.','2','.','.','.','6' },
            //    new char[] { '.','6','.','.','.','.','2','8','.' },
            //    new char[] { '.','.','.','4','1','9','.','.','5' },
            //    new char[] { '.','.','.','.','8','.','.','7','9' },
            //};
            //Console.WriteLine(sudoku.IsValidSudoku(board));

            //Sequence seq = new();
            //Console.WriteLine(seq.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }));

            //MajorityElement_N3 majorityElements = new();
            //PrintArray(majorityElements.FindMajorityElements(new int[] { 1, 2, 1, 1, 2, 2, 3, 4, 2 }));

            //StableContinousSubArray stableContinousSubArray = new();
            //// List<int> result = stableContinousSubArray.Find(new List<int>() { 4, 2, 3, 6, 2, 2, 3, 2, 7 }, 1);
            //List<int> result = stableContinousSubArray.Find(new List<int>() { 8, 2, 4 ,7 }, 4);
            //PrintArray(result.ToArray());

            //NextLargestPallindrome nextLargestPallindrome = new();
            //// Case 1
            //Console.WriteLine($"1000 --> {nextLargestPallindrome.Get(1000)}");
            //Console.WriteLine($"3421 --> {nextLargestPallindrome.Get(3421)}");
            //Console.WriteLine($"321 --> {nextLargestPallindrome.Get(321)}");
            //Console.WriteLine($"992 --> {nextLargestPallindrome.Get(992)}");
            //Console.WriteLine($"9992 --> {nextLargestPallindrome.Get(9992)}");

            //// Case 2
            //Console.WriteLine($"1388 --> {nextLargestPallindrome.Get(1388)}");
            //Console.WriteLine($"1241 --> {nextLargestPallindrome.Get(1241)}");
            //Console.WriteLine($"12345678 --> {nextLargestPallindrome.Get(12345678)}");
            //Console.WriteLine($"1238855678 --> {nextLargestPallindrome.Get(1238855678)}");
            //Console.WriteLine($"10001388 --> {nextLargestPallindrome.Get(10001388)}");
            //Console.WriteLine($"5611832 --> {nextLargestPallindrome.Get(5611832)}");

            //// Case 3
            //Console.WriteLine($"198 --> {nextLargestPallindrome.Get(198)}");
            //Console.WriteLine($"1988 --> {nextLargestPallindrome.Get(1988)}");

            // Quad Tree
            QuadTree tree = new(new int[,]
            {
                { 2, 2, 3, 3 },
                { 2, 2, 3, 3 },
                { 4, 2, 5, 5 },
                { 2, 3, 5, 5 },
            });
            Console.ReadKey();
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
