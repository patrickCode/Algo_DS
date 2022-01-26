using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class ValidAnagramTest
    {
        [TestMethod]
        public void Nameless_Equals_Salesmen()
        {
            Assert.IsTrue(ValidAnagrams.AreAnagrams("nameless", "salesmen"));
        }

        [TestMethod]
        public void Nameless_NotEquals_Salesman()
        {
            Assert.IsFalse(ValidAnagrams.AreAnagrams("nameless", "salesman"));
        }
    }
}
