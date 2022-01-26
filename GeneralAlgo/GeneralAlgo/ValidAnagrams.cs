using System.Linq;
using System.Collections.Generic;

namespace GeneralAlgo
{
    public static class ValidAnagrams
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> characterHash = new();
            foreach(char c in s1)
            {
                if (characterHash.ContainsKey(c))
                    characterHash[c]++;
                else
                    characterHash.Add(c, 1);
            }

            foreach (char c in s2)
            {
                if (characterHash.ContainsKey(c))
                    characterHash[c]--;
                else
                    return false;
            }

            return characterHash.All(hash => hash.Value == 0);
        }
    }
}
