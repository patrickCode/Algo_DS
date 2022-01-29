namespace Tries
{
    public class TrieNode
    {
        public char Value { get; set; }
        public Dictionary<char, TrieNode> Children { get; set; }
        public bool IsLeaf { get; set; }

        public TrieNode() 
        {
            Children = new Dictionary<char, TrieNode>();
            IsLeaf = false;
        }

        public TrieNode(char value)
            :this()
        {
            Value = value;
        }
    }
}
