//// https://leetcode.com/problems/valid-palindrome/
//// https://leetcode.com/submissions/detail/1202913358/
//using System.Text;

//public class Solution
//{
//    private static int LowerToUpperCaseDiff = 'a' - 'A';
//    public bool IsPalindrome(string s)
//    {
//        string sanitizedString = GetSanitizedString(s);
//        return IsSanitizedStringPalindrome(sanitizedString);
//    }

//    private string GetSanitizedString(string s)
//    {
//        StringBuilder sanitizedString = new();
//        foreach (char c in s)
//        {
//            if (IsUpper(c))
//            {
//                sanitizedString.Append(ConvertToLowercase(c));
//                continue;
//            }
//            if (IsLower(c))
//            {
//                sanitizedString.Append(c);
//                continue;
//            }

//            if (IsDigit(c))
//            {
//                sanitizedString.Append(c);
//                continue;
//            }
//        }
//        return sanitizedString.ToString();
//    }

//    private bool IsSanitizedStringPalindrome(string s)
//    {
//        if (string.IsNullOrEmpty(s))
//        {
//            return true;
//        }
//        int length = s.Length;
//        if (length == 1)
//        {
//            return true;
//        }
//        for (int index = 0; index < length / 2; index++)
//        {
//            if (s[index] != s[length - index - 1])
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    private bool IsUpper(char c)
//    {
//        return c >= 'A' && c <= 'Z';
//    }

//    private bool IsLower(char c)
//    {
//        return c >= 'a' && c <= 'z';
//    }

//    private bool IsDigit(char c)
//    {
//        return c >= '0' && c <= '9';
//    }

//    private char ConvertToLowercase(char c)
//    {
//        return (char)((int)c + LowerToUpperCaseDiff);
//    }
//}