using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tries.Tests
{
    [TestClass]
    public class TrieTests
    {
        [TestMethod]
        public void TestCase1_AddAndSearchWords_SamePrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");

            Assert.IsTrue(trie.Search("flow"));
            Assert.IsTrue(trie.Search("flaw"));
            Assert.IsTrue(trie.Search("fleece"));
            Assert.IsTrue(trie.Search("flute"));
            Assert.IsFalse(trie.Search("flown"));
            Assert.IsFalse(trie.Search("flee"));
            Assert.IsFalse(trie.Search("box"));
        }

        [TestMethod]
        public void TestCase1_AddAndSearchWords_MultiplePrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");
            trie.Add("box");
            trie.Add("boxer");
            trie.Add("flute");
            trie.Add("bond");
            trie.Add("car");
            trie.Add("cars");

            Assert.IsTrue(trie.Search("flow"));
            Assert.IsTrue(trie.Search("flaw"));
            Assert.IsTrue(trie.Search("fleece"));
            Assert.IsTrue(trie.Search("flute"));
            Assert.IsTrue(trie.Search("box"));
            Assert.IsTrue(trie.Search("boxer"));
            Assert.IsFalse(trie.Search("bo"));
            Assert.IsFalse(trie.Search("flown"));
            Assert.IsFalse(trie.Search("flee"));
        }

        [TestMethod]
        public void TestCase1_AddAndStartsWith_SamePrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");

            Assert.IsTrue(trie.StartsWith("fl"));
            Assert.IsTrue(trie.StartsWith("flow"));
            Assert.IsTrue(trie.StartsWith("flee"));
            Assert.IsTrue(trie.StartsWith("flut"));
            Assert.IsTrue(trie.StartsWith("fla"));
            Assert.IsFalse(trie.StartsWith("ff"));
            Assert.IsFalse(trie.StartsWith("box"));
        }

        [TestMethod]
        public void TestCase1_AddAndStartsWith_MultiplePrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");
            trie.Add("box");
            trie.Add("boxer");
            trie.Add("flute");
            trie.Add("bond");
            trie.Add("car");
            trie.Add("cars");

            Assert.IsTrue(trie.StartsWith("fl"));
            Assert.IsTrue(trie.StartsWith("flow"));
            Assert.IsTrue(trie.StartsWith("flee"));
            Assert.IsTrue(trie.StartsWith("flut"));
            Assert.IsTrue(trie.StartsWith("fla"));
            Assert.IsFalse(trie.StartsWith("ff"));
            Assert.IsTrue(trie.StartsWith("bo"));
            Assert.IsTrue(trie.StartsWith("box"));
            Assert.IsTrue(trie.StartsWith("ca"));
            Assert.IsTrue(trie.StartsWith("cars"));
        }

        [TestMethod]
        public void TestCase1_AddAndGetMatchingWords_MultiplePrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");
            trie.Add("box");
            trie.Add("boxer");
            trie.Add("flute");
            trie.Add("bond");
            trie.Add("car");
            trie.Add("cars");

            IEnumerable<string> matchedWords = trie.Autocomplete("fl");

            Assert.AreEqual(4, matchedWords.Count());
            Assert.IsTrue(matchedWords.Any(word => word == "flow"));
            Assert.IsTrue(matchedWords.Any(word => word == "flaw"));
            Assert.IsTrue(matchedWords.Any(word => word == "fleece"));
            Assert.IsTrue(matchedWords.Any(word => word == "flute"));
            Assert.IsFalse(matchedWords.Any(word => word == "box"));
            Assert.IsFalse(matchedWords.Any(word => word == "cars"));
        }

        [TestMethod]
        public void TestCase1_AddAndGetMatchingWords_RepeatingPrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");
            trie.Add("box");
            trie.Add("boxer");
            trie.Add("flute");
            trie.Add("bond");
            trie.Add("car");
            trie.Add("cars");

            IEnumerable<string> matchedWords = trie.Autocomplete("bo");

            Assert.AreEqual(3, matchedWords.Count());
            Assert.IsTrue(matchedWords.Any(word => word == "box"));
            Assert.IsTrue(matchedWords.Any(word => word == "boxer"));
            Assert.IsTrue(matchedWords.Any(word => word == "bond"));
        }

        [TestMethod]
        public void TestCase1_AddAndGetMatchingWords_ExactPrefix()
        {
            Trie trie = new();
            trie.Add("flow");
            trie.Add("flaw");
            trie.Add("fleece");
            trie.Add("flute");
            trie.Add("box");
            trie.Add("boxer");
            trie.Add("flute");
            trie.Add("bond");
            trie.Add("car");
            trie.Add("cars");

            IEnumerable<string> matchedWords = trie.Autocomplete("cars");

            Assert.AreEqual(1, matchedWords.Count());
            Assert.IsTrue(matchedWords.Any(word => word == "cars"));
        }
    }
}