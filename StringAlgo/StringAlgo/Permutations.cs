using System;
using System.Linq;
using System.Collections.Generic;

namespace StringAlgo
{
    /// <summary>
    /// Check if 2 strings are permutations of each other
    /// </summary>
    public class Permutations
    {
        public static bool IsPermutation_Sort(string input1, string input2)
        {
            if (string.IsNullOrWhiteSpace(input1) && string.IsNullOrWhiteSpace(input2))
                return true;
            if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2))
                return false;
            if (input1.Length != input2.Length)
                return false;

            char[] input1_arr = input1.ToLowerInvariant().ToCharArray();
            char[] input2_arr = input2.ToLowerInvariant().ToCharArray();

            Array.Sort(input1_arr);
            Array.Sort(input2_arr);

            for (int index = 0; index < input1_arr.Length; index++)
            {
                if (input1_arr[index] != input2_arr[index])
                    return false;
            }
            return true;
        }

        public static bool IsPermutation_Hash(string input1, string input2)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            foreach(char character in input1.ToLowerInvariant())
            {
                if (hash.ContainsKey(character))
                    hash[character]++;
                else
                    hash[character] = 1;
            }

            foreach (char character in input2.ToLowerInvariant())
            {
                if (!hash.ContainsKey(character))
                    return false;
                else
                    hash[character]--;
            }

            return hash.All(ch => ch.Value == 0);
        }

        public static void Test()
        {
            Console.WriteLine("SORT");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Test Case 1: Exact same strings: " + (IsPermutation_Sort("BACDEFGHIJKLMNOPQRSTUVWXYZ", "BACDEFGHIJKLMNOPQRSTUVWXYZ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 2: Exact same strings (case sensitive): " + (IsPermutation_Sort("BACDEFGHIJKLMNOpqrstuvwxyz", "bacdefghijkLMNOPQRSTUVWXYZ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 3: Same characters with different permutation: " + (IsPermutation_Sort("QETUOPIYRW", "POIUYTREWQ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 4: Complete Different strings with same length: " + (IsPermutation_Sort("ASDFGHJKL", "ZXCVBNMLO") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 5: Different strings with 1 difference: " + (IsPermutation_Sort("ASDFGHJKL", "ASDFGHJKY") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 6: Different strings with 2 differences: " + (IsPermutation_Sort("ASDFGHJKL", "ASDFGHJAY") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 7: Both empty strings: " + (IsPermutation_Sort("", "") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 8: 1 empty string: " + (IsPermutation_Sort("", "ABVC") ? "Failed" : "Passed"));

            Console.WriteLine("HASH");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Test Case 1: Exact same strings: " + (IsPermutation_Hash("BACDEFGHIJKLMNOPQRSTUVWXYZ", "BACDEFGHIJKLMNOPQRSTUVWXYZ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 2: Exact same strings (case sensitive): " + (IsPermutation_Hash("BACDEFGHIJKLMNOpqrstuvwxyz", "bacdefghijkLMNOPQRSTUVWXYZ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 3: Same characters with different permutation: " + (IsPermutation_Hash("QETUOPIYRW", "POIUYTREWQ") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 4: Complete Different strings with same length: " + (IsPermutation_Hash("ASDFGHJKL", "ZXCVBNMLO") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 5: Different strings with 1 difference: " + (IsPermutation_Hash("ASDFGHJKL", "ASDFGHJKY") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 6: Different strings with 2 differences: " + (IsPermutation_Hash("ASDFGHJKL", "ASDFGHJAY") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 7: Both empty strings: " + (IsPermutation_Hash("", "") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 8: 1 empty string: " + (IsPermutation_Hash("", "ABVC") ? "Failed" : "Passed"));
        }
    }
}
