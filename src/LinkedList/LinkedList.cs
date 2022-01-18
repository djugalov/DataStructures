using System.Collections.Generic;

namespace LinkedList
{
    public class LinkedList<T> where T : class
    {
        public LinkedList()
        {

        }

        public LinkedListNode<T> Head { get; private set; }

        public LinkedListNode<T> Tail { get; private set; }

        public void AddFirst(LinkedListNode<T> node)
        {
            if (Head == null)
            {
                Tail = node;

                Head = node;
                
                Head.Next = Tail;
            }
            else
            {
                node.Next = Head;

                Head = node;
            }
        }

        public void AddLast(LinkedListNode<T> node)
        {
            if (Tail == null)
            {
                Head = node;

                Tail = node;

                Head.Next = Tail;

                Tail.Previous = Head;
            }
            else
            {
                var oldTail = Tail;

                oldTail.Next = node;

                Tail = node;
                
                Tail.Previous = oldTail;
            }
        }

        public void AddAfter(LinkedListNode<T> nodeBefore, LinkedListNode<T> node)
        {
            LinkedListNode<T> nodeAfter = nodeBefore.Next;

            nodeBefore.Next = node;

            node.Next = nodeAfter;
        }

        public void AddBefore(LinkedListNode<T> nodeAfter, LinkedListNode<T> node)
        {
            LinkedListNode<T> nodeBefore = nodeAfter.Previous;

            if(nodeBefore == null)
            {
                Head = node;
                Head.Next = nodeAfter;
            }
            else
            {
                nodeAfter.Previous = node;

                node.Previous = nodeBefore;

                node.Next = nodeAfter;

                nodeBefore.Next = node;
            }
        }

        public void PrintAllNodes()
        {
            var tempHead = Head;

            while (tempHead != null)
            {
                System.Console.WriteLine(tempHead.Data);

                tempHead = tempHead.Next;
            }
        }
    }
}
