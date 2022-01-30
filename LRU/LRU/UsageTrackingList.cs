namespace LRU
{
    internal class UsageTrackingList<TKey, TVal>
    {
        private ValueNode<TKey, TVal> _mostRecentlyUsedNode;
        private ValueNode<TKey, TVal> _leastRecentlyUsedNode;

        public UsageTrackingList() 
        {
            _mostRecentlyUsedNode = null;
            _leastRecentlyUsedNode = null;
        }

        public void AddNode(ValueNode<TKey, TVal> value)
        {
            if (_mostRecentlyUsedNode == null)
            {
                _mostRecentlyUsedNode = value;
                _leastRecentlyUsedNode = _mostRecentlyUsedNode;
                return;
            }

            _mostRecentlyUsedNode.Next = value;
            value.Prev = _mostRecentlyUsedNode;
            _mostRecentlyUsedNode = _mostRecentlyUsedNode.Next;
        }

        public void MoveToRecentlyUsed(ValueNode<TKey, TVal> node)
        {
            if (_mostRecentlyUsedNode.Key.Equals(node.Key))
                return;

            if (node.Key.Equals(_leastRecentlyUsedNode.Key))
            {
                _leastRecentlyUsedNode = _leastRecentlyUsedNode.Next;
                _leastRecentlyUsedNode.Prev = null;
            }

            if (node.Prev != null)
                node.Prev.Next = node.Next;
            if (node.Next != null)
                node.Next.Prev = node.Prev;

            _mostRecentlyUsedNode.Next = node;
            node.Prev = _mostRecentlyUsedNode;
            _mostRecentlyUsedNode = _mostRecentlyUsedNode.Next;
            _mostRecentlyUsedNode.Next = null;
        }

        public ValueNode<TKey, TVal> DeleteLeastRecentlyUsedNode()
        {
            ValueNode<TKey, TVal> deletedNode = _leastRecentlyUsedNode;
            _leastRecentlyUsedNode = _leastRecentlyUsedNode.Next;
            _leastRecentlyUsedNode.Prev = null;
            return deletedNode;
        }
    }
}
