using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkLists.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void Should_Return_True_For_Event_Palindrome()
        {
            var list = new Node("1 2 2 1");
            var isPalindrome = new Palindrome().IsPalindrome(list);
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void Should_Return_True_For_Odd_Palindrome()
        {
            var list = new Node("1 2 1");
            var isPalindrome = new Palindrome().IsPalindrome(list);
            Assert.IsTrue(isPalindrome);
        }

        [TestMethod]
        public void Should_Return_False_For_Non_Palindrome()
        {
            var list = new Node("1 2 1 5 4");
            var isPalindrome = new Palindrome().IsPalindrome(list);
            Assert.IsFalse(isPalindrome);
        }
    }
}
