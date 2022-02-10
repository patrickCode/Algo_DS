// Reference: https://www.youtube.com/watch?v=HAA8mgxlov8
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
            return Match(word, 0, _pattern, 0);
        }

        private bool Match(string word, int wordIndex, string pattern, int patternIndex)
        {
            bool isWordInBound = wordIndex < word.Length;
            bool isPatternInBound = patternIndex < pattern.Length;

            if (!isWordInBound && !isPatternInBound)
                return true;

            if (!isPatternInBound && isWordInBound)
                return false;

            char patternToMatch = pattern[patternIndex];
            char wordToMatch = isWordInBound ? word[wordIndex] : ' ';

            bool isStarPattern = patternIndex < pattern.Length - 1 && pattern[patternIndex + 1] == '*';
            bool isPatternIndexMatching = isWordInBound && (wordToMatch == patternToMatch || patternToMatch == '.');

            if (!isStarPattern)
            {
                if (isPatternIndexMatching) 
                {
                    return Match(word, wordIndex + 1, pattern, patternIndex + 1);
                }
                return false;
            }

            if (isPatternIndexMatching)
            {
                return Match(word, wordIndex + 1, pattern, patternIndex + 2) // Choice 1: Match the star pattern once
                    || Match(word, wordIndex, pattern, patternIndex + 2) // Choice 2: Don't match the star pattern (0 times)
                    || Match(word, wordIndex + 1, pattern, patternIndex); // Choice: Match the star pattern multiple times
            }
            return Match(word, wordIndex, pattern, patternIndex + 2);
        }
    }
}
