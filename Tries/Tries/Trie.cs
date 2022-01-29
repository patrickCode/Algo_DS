namespace Tries
{
    public class Trie
    {
        private readonly TrieNode _root;

        public Trie()
        {
            _root = new();
        }

        public void Add(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return;

            TrieNode tempNode = _root;
            foreach(char c in word)
            {
                TrieNode nextNode = tempNode.Children.FirstOrDefault(child => child.Key == c).Value;
                if (nextNode != null)
                {
                    tempNode = nextNode;
                    continue;
                }

                nextNode = new(c);
                tempNode.Children.Add(c, nextNode);
                tempNode = nextNode;
            }
            tempNode.IsLeaf = true;
        }

        public bool Search(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;

            TrieNode tempNode = _root;
            foreach (char c in word)
            {
                TrieNode nextNode = tempNode.Children.FirstOrDefault(child => child.Key == c).Value;
                if (nextNode != null)
                {
                    tempNode = nextNode;
                    continue;
                }
                return false;
            }
            return tempNode.IsLeaf;
        }

        public bool StartsWith(string prefix)
        {
            if (string.IsNullOrWhiteSpace(prefix))
                return true;

            TrieNode tempNode = _root;
            foreach (char c in prefix)
            {
                TrieNode nextNode = tempNode.Children.FirstOrDefault(child => child.Key == c).Value;
                if (nextNode != null)
                {
                    tempNode = nextNode;
                    continue;
                }
                return false;
            }
            return true;
        }
    }
}
