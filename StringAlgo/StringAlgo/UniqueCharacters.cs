using System;
using System.Collections.Generic;

namespace StringAlgo
{
    /// <summary>
    /// Check if all the characters of a string are unique
    /// </summary>
    public class UniqueCharacters
    {
        public static bool IsUnique(string str)
        {   
            if (string.IsNullOrEmpty(str))
                return true;
            HashSet<char> characters = new HashSet<char>();

            foreach(char character in str) 
            {
                if (characters.Contains(character))
                    return false;
                characters.Add(character);
            }
            return true;
        }

        public static void Test()
        {
            Console.WriteLine("Test Case 1 - all characters in an english alphabet: " + (IsUnique("abcdefghijklmnopqrstuvwxyz") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 2 - repeated characters: " + (IsUnique("abcdefghijklmnopqrabhysz") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 3 - all alphanumeric: " + (IsUnique("abcdefghijklmnopqrstuvwxyz0123456789") ? "Passed" : "Failed"));
            Console.WriteLine("Test Case 4 - all alphanumeric with repeatations: " + (IsUnique("001abcdefghijklmnopqrstuvwxyz0123456789") ? "Failed" : "Passed"));
            Console.WriteLine("Test Case 5 - empty: " + (IsUnique("") ? "Passed" : "Failed"));
        }
    }
}
