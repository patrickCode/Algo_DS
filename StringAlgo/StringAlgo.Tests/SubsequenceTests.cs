using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAlgo.Tests
{
    [TestClass]
    public class SubsequenceTests
    {
        [TestMethod]
        public void abc_is_subsequence_of_abhdc()
        {
            var source = "abc";
            var target = "abhdc";
            Assert.IsTrue(Subsequence.IsSubsequence(source, target));
        }

        [TestMethod]
        public void axc_is_not_subsequence_of_abhdc()
        {
            var source = "axc";
            var target = "abhdc";
            Assert.IsFalse(Subsequence.IsSubsequence(source, target));
        }
    }
}
