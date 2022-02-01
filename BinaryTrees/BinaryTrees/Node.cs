namespace BinaryTrees
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public bool IsLeaf()
        {
            return Left == null && Right == null;
        }
    }
}
