using GeneralAlgo;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class DialPadTests
    {
        [TestMethod]
        public void Generate_23()
        {
            DialPad dialPad = new();
            List<string> combinations = dialPad.GenerateCombinations(23);
            Assert.AreEqual(9, combinations.Count);
            Assert.IsTrue(combinations.Contains("AD"));
            Assert.IsTrue(combinations.Contains("AE"));
            Assert.IsTrue(combinations.Contains("AF"));
            Assert.IsTrue(combinations.Contains("BD"));
            Assert.IsTrue(combinations.Contains("BE"));
            Assert.IsTrue(combinations.Contains("BF"));
            Assert.IsTrue(combinations.Contains("CD"));
            Assert.IsTrue(combinations.Contains("CE"));
            Assert.IsTrue(combinations.Contains("CF"));
        }

        [TestMethod]
        public void Generate_234()
        {
            DialPad dialPad = new();
            List<string> combinations = dialPad.GenerateCombinations(234);
            Assert.AreEqual(27, combinations.Count);
            Assert.IsTrue(combinations.Contains("ADG"));
            Assert.IsTrue(combinations.Contains("ADH"));
            Assert.IsTrue(combinations.Contains("ADI"));
            Assert.IsTrue(combinations.Contains("AEG"));
            Assert.IsTrue(combinations.Contains("AEH"));
            Assert.IsTrue(combinations.Contains("AEI"));
            Assert.IsTrue(combinations.Contains("AFG"));
            Assert.IsTrue(combinations.Contains("AFH"));
            Assert.IsTrue(combinations.Contains("AFI"));
            Assert.IsTrue(combinations.Contains("BDG"));
            Assert.IsTrue(combinations.Contains("BDH"));
            Assert.IsTrue(combinations.Contains("BDI"));
            Assert.IsTrue(combinations.Contains("BEG"));
            Assert.IsTrue(combinations.Contains("BEH"));
            Assert.IsTrue(combinations.Contains("BEI"));
            Assert.IsTrue(combinations.Contains("BFG"));
            Assert.IsTrue(combinations.Contains("BFH"));
            Assert.IsTrue(combinations.Contains("BFI"));
            Assert.IsTrue(combinations.Contains("CDG"));
            Assert.IsTrue(combinations.Contains("CDH"));
            Assert.IsTrue(combinations.Contains("CDI"));
            Assert.IsTrue(combinations.Contains("CEG"));
            Assert.IsTrue(combinations.Contains("CEH"));
            Assert.IsTrue(combinations.Contains("CEI"));
            Assert.IsTrue(combinations.Contains("CFG"));
            Assert.IsTrue(combinations.Contains("CFH"));
            Assert.IsTrue(combinations.Contains("CFI"));
        }
    }
}
