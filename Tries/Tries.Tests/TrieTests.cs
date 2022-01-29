using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}