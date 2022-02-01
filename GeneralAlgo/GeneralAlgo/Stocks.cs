using System.IO;
using System.Linq;

namespace GeneralAlgo
{
    public class Stocks
    {
        private readonly int[] _prices;

        public Stocks(int[] prices)
        {
            _prices = prices;
        }

        public int GetMaxProfitWithSingleTransaction()
        {
            int buyPointer = 0;
            int sellPointer = 1;

            int maxProfit = -10000;

            while (sellPointer < _prices.Count())
            {
                int costPrice = _prices[buyPointer];
                int sellingPrice = _prices[sellPointer];

                int profit = sellingPrice - costPrice;
                if (profit > maxProfit)
                    maxProfit = profit;

                if (profit < 0)
                {
                    buyPointer = sellPointer;
                }
                sellPointer++;
            }
            return maxProfit;
        }

        public int GetMaxProfitWithMultipleTransaction()
        {
            int buyPointer = 0;
            int sellPointer = 1;
            int totalProfit = 0;

            while (sellPointer < _prices.Count())
            {
                int costPrice = _prices[buyPointer];
                int sellingPrice = _prices[sellPointer];

                if (sellingPrice < costPrice)
                {
                    buyPointer = sellPointer;
                    sellPointer++;
                    continue;
                }

                int lastSellingPrice = sellingPrice;
                while (sellingPrice >= lastSellingPrice)
                {
                    sellPointer++;
                    sellingPrice = _prices[sellPointer];
                }
                totalProfit += (lastSellingPrice - costPrice);
                buyPointer = sellPointer;
                sellPointer++;
            }
            return totalProfit;
        }
    }
}