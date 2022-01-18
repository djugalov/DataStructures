namespace LinkedList
{
    public class LinkedListNode<T> where T : class
    {
        public LinkedListNode(T data)
        {
            Data = data;
        }

        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode<T> Previous { get; set; }

        public T Data { get; private set; }

    }
}
