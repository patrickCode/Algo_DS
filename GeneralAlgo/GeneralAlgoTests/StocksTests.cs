using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class StocksTests
    {
        [TestMethod]
        public void TestCase1_MaxProfit_SingleTransaction()
        {
            Stocks stocks = new(new int[] { 7, 1, 5, 3, 6, 4 });
            int maxProfit = stocks.GetMaxProfitWithSingleTransaction();
            Assert.AreEqual(5, maxProfit);
        }

        [TestMethod]
        public void TestCase1_MaxProfit_MultipleTransaction()
        {
            Stocks stocks = new(new int[] { 7, 1, 5, 3, 6, 4 });
            int maxProfit = stocks.GetMaxProfitWithMultipleTransaction();
            Assert.AreEqual(7, maxProfit);
        }
    }
}
