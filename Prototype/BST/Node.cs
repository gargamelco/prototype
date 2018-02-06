namespace Prototype.BST
{
    public class Node<T>
    {
        public float value;
        public Node<T> left { get; set; }
        public Node<T> right { get; set; }

        public Node(float value)
        {
            this.value = value;
        }
    }
}
