namespace LRU
{
    internal class ValueNode<TKey, TVal>
    {
        public TKey Key { get; set; }
        public TVal Value { get; set; }
        public ValueNode<TKey, TVal> Prev { get; set; }
        public ValueNode<TKey, TVal> Next { get; set; }

        public ValueNode(TKey key, TVal value)
        {
            Key = key;
            Value = value;
        }
    }
}
