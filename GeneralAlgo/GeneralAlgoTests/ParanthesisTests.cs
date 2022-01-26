using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GeneralAlgoTests
{
    [TestClass]
    public class ParanthesisTests
    {
        [TestMethod]
        public void TestCase_1()
        {
            string paranthesis = "((()))";
            Assert.IsTrue(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void TestCase_2()
        {
            string paranthesis = "()()()";
            Assert.IsTrue(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void TestCase_3()
        {
            string paranthesis = "(()())";
            Assert.IsTrue(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void TestCase_4_Unclosed()
        {
            string paranthesis = "(()()";
            Assert.IsFalse(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void TestCase_4_ExtraClosed()
        {
            string paranthesis = "(()()))";
            Assert.IsFalse(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void TestCase_4_WrongClosed()
        {
            string paranthesis = "(()))()";
            Assert.IsFalse(Paranthesis.IsValid(paranthesis));
        }

        [TestMethod]
        public void Generate_1() 
        {
            List<string> paranthesis = Paranthesis.Generate(1);
            Assert.IsTrue(paranthesis.Any());
            Assert.AreEqual("()", paranthesis.First());
        }


        [TestMethod]
        public void Generate_3()
        {
            List<string> paranthesis = Paranthesis.Generate(3);
            Assert.AreEqual(5, paranthesis.Count());
            Assert.IsTrue(paranthesis.Contains("((()))"));
            Assert.IsTrue(paranthesis.Contains("(()())"));
            Assert.IsTrue(paranthesis.Contains("(())()"));
            Assert.IsTrue(paranthesis.Contains("()(())"));
            Assert.IsTrue(paranthesis.Contains("()()()"));
        }
    }
}
