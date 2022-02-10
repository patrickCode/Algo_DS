using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class RergexTests
    {
        [TestMethod]
        public void Regex_Verify_aa_matches_aa()
        {
            string word = "aa";
            string pattern = "aa";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }


        [TestMethod]
        public void Regex_Verify_aa_matches_a_star()
        {
            string word = "aa";
            string pattern = "a*";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_aa_matches_a_dot()
        {
            string word = "aa";
            string pattern = "a.";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_ab_matches_dot_star()
        {
            string word = "aa";
            string pattern = ".*";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_aaaa_matches_a_star()
        {
            string word = "aaaa";
            string pattern = "a*";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_aab_matches_a_star_b()
        {
            string word = "aab";
            string pattern = "a*b";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_aab_matches_c_star_a_star_b()
        {
            string word = "aab";
            string pattern = "c*a*b";
            Regex regex = new(pattern);
            Assert.IsTrue(regex.Match(word));
        }

        [TestMethod]
        public void Regex_Verify_aaba_does_not_matches_c_star_a_star_b()
        {
            string word = "aaba";
            string pattern = "c*a*b";
            Regex regex = new(pattern);
            Assert.IsFalse(regex.Match(word));
        }
    }
}
