// Reference: https://www.youtube.com/watch?v=HAA8mgxlov8
using System.Collections.Generic;

namespace GeneralAlgo
{
    public class Regex
    {
        private readonly string _pattern;
        public Regex(string pattern)
        {
            _pattern = pattern;
        }

        public bool Match(string word)
        {
            return Match(word, 0, _pattern, 0, new());
        }

        private bool Match(string word, int wordIndex, string pattern, int patternIndex, Dictionary<string, bool> cache)
        {
            string indexCacheKey = $"{wordIndex},{patternIndex}";
            if (cache.ContainsKey(indexCacheKey))
                return cache[indexCacheKey];

            bool isWordInBound = wordIndex < word.Length;
            bool isPatternInBound = patternIndex < pattern.Length;

            if (!isWordInBound && !isPatternInBound)
                return true;

            if (!isPatternInBound && isWordInBound)
                return false;

            char patternToMatch = pattern[patternIndex];
            char wordToMatch = isWordInBound ? word[wordIndex] : '\0';

            bool isStarPattern = patternIndex < pattern.Length - 1 && pattern[patternIndex + 1] == '*';
            bool isPatternIndexMatching = isWordInBound && (wordToMatch == patternToMatch || patternToMatch == '.');

            if (!isStarPattern)
            {
                if (isPatternIndexMatching) 
                {
                    bool isMatch = Match(word, wordIndex + 1, pattern, patternIndex + 1, cache);
                    cache.Add(indexCacheKey, isMatch);
                    return isMatch;
                }
                cache.Add(indexCacheKey, false);
                return false;
            }

            if (isPatternIndexMatching)
            {
                bool isMatch = Match(word, wordIndex + 1, pattern, patternIndex + 2, cache) // Choice 1: Match the star pattern once
                    || Match(word, wordIndex, pattern, patternIndex + 2, cache) // Choice 2: Don't match the star pattern (0 times)
                    || Match(word, wordIndex + 1, pattern, patternIndex, cache); // Choice: Match the star pattern multiple times
                cache.Add(indexCacheKey, isMatch);
                return isMatch;
            }
            bool isNextPattenMacthed = Match(word, wordIndex, pattern, patternIndex + 2, cache);
            cache.Add(indexCacheKey, isNextPattenMacthed);
            return isNextPattenMacthed;
        }
    }
}
