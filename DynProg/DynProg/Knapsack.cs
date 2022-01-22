using System;

namespace DynProg
{
    internal class Knapsack
    {
        private static int Maximize_Recur(Item[] items, int capacityLeft, int itemsLeft)
        {
            // Basic choice - If the weight of a item is greater than the capacity left then do not include the item in bag
            // If the weight of an item is lesser than capacity left, then we can either include it or not include it - recursive tree

            if (itemsLeft == 0 || capacityLeft == 0)
                return 0;

            Item currentItem = items[itemsLeft - 1];
            if (currentItem.Weight > capacityLeft)
                return Maximize_Recur(items, capacityLeft, itemsLeft - 1);

            int newCapacity = capacityLeft - currentItem.Weight;
            return Math.Max(
                currentItem.Value + Maximize_Recur(items, newCapacity, itemsLeft - 1), // Take the item
                Maximize_Recur(items, capacityLeft, itemsLeft - 1)); // Do not take the item
        }

        //private static int Maximize(Item[] items, int capacityLeft, int itemsLeft)
        //{
        //    // For DP we generally create the matrix of values which are changing - in this case the capacity and items left are changing
        //}

        public static void Test()
        {
            Item[] items = new Item[4]
            {
                new Item(1, 1),
                new Item(3, 4),
                new Item(4, 5),
                new Item(5, 7)
            };
            int maxWeight = Maximize_Recur(items, 7, items.Length);
            Console.WriteLine(maxWeight);
        }
    }

    internal class Item
    {
        public int Weight { get; set; }
        public int Value { get; set; }
        

        public Item(int weight, int value)
        {   
            Weight = weight;
            Value = value;
        }
    }
}
