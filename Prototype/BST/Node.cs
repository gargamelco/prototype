namespace Prototype.BST
{
    public class Node<T>
    {
        public T value;
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }

        public Node(T value)
        {
            this.value = value;
        }
    }
}
