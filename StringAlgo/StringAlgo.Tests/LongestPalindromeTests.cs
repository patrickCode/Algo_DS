using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAlgo.Tests
{
    [TestClass]
    public class LongestPalindromeTests
    {
        [TestMethod]
        public void forgeeksskeegfor_should_be_geeksskeeg()
        {
            var input = "forgeeksskeegfor";
            var expectedOutput = "geeksskeeg";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void REDAABBAATYU_should_be_AABBAA()
        {
            var input = "REDAABBAATYU";
            var expectedOutput = "AABBAA";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void AYHUIIUHJOKO_should_be_OKO()
        {
            var input = "AYHUIIUHJOKO";
            var expectedOutput = "HUIIUH";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void abaaba_should_be_abaaba()
        {
            var input = "abaaba";
            var expectedOutput = "abaaba";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void abababa_should_be_abababa()
        {
            var input = "abababa";
            var expectedOutput = "abababa";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void abcbabcbabcba_should_be_abcbabcbabcba()
        {
            var input = "abcbabcbabcba";
            var expectedOutput = "abcbabcbabcba";
            var actualOutput = LongestPalindrome.GetLongestPalindrome(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
