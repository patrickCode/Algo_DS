namespace LRU
{
    public class Cache<TKey, TVal>
    {
        private readonly Dictionary<TKey, ValueNode<TKey, TVal>> _cache;
        private readonly UsageTrackingList<TKey, TVal> _trackingList;
        private readonly int _totalCapacity;
        private int CurrentCapacity;

        public Cache(int capacity)
        {
            _totalCapacity = capacity;
            _cache = new Dictionary<TKey, ValueNode<TKey, TVal>>();
            _trackingList = new UsageTrackingList<TKey, TVal>();
            CurrentCapacity = 0;
        }

        public TVal Get(TKey key)
        {
            if (!_cache.ContainsKey(key))
                return default;

            var cachedNode = _cache[key];
            _trackingList.MoveToRecentlyUsed(cachedNode);
            return cachedNode.Value;
        }

        public void Set(TKey key, TVal value)
        {
            if (CurrentCapacity < _totalCapacity)
            {
                AddToCache(key, value);
                return;
            }

            ValueNode<TKey, TVal> evictedNode = _trackingList.DeleteLeastRecentlyUsedNode();
            _cache.Remove(evictedNode.Key);
            CurrentCapacity--;
            AddToCache(key, value);
        }

        private void AddToCache(TKey key, TVal value)
        {
            if (_cache.ContainsKey(key))
            {
                ValueNode<TKey, TVal> cachedNode = _cache[key];
                cachedNode.Value = value;
                _trackingList.MoveToRecentlyUsed(cachedNode);
                return;
            }
            ValueNode<TKey, TVal> newNode = new(key, value);
            _trackingList.AddNode(newNode);
            _cache.Add(key, newNode);
            CurrentCapacity++;
            return;
        }
    }
}
