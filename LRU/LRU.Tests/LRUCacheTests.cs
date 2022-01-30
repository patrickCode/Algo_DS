using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LRU.Tests
{
    [TestClass]
    public class LRUCacheTests
    {
        [TestMethod]
        public void TestCase1_CacheOfSize2()
        {
            Cache<int, int> cache = new(2);
            cache.Set(1, 1);
            cache.Set(2, 2);
            Assert.AreEqual(1, cache.Get(1));
            cache.Set(3, 3);
            Assert.AreEqual(default, cache.Get(2));
            cache.Set(4, 4);
            Assert.AreEqual(default, cache.Get(1));
            Assert.AreEqual(3, cache.Get(3));
            Assert.AreEqual(4, cache.Get(4));
        }
    }
}