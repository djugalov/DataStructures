using System;

namespace LinkedList
{
    class Program
    {
        static void Main()
        {
            var linkedList = new LinkedList<string>();

            var firstNode = new LinkedListNode<string>("first");

            linkedList.AddFirst(firstNode);

            var firstNodeAddedBeforeFirst = new LinkedListNode<string>("second");

            linkedList.AddBefore(firstNode, firstNodeAddedBeforeFirst);

            var lastNode = new LinkedListNode<string>("last");

            linkedList.AddLast(lastNode);

            var nodeBeforeLast = new LinkedListNode<string>("test");

            linkedList.AddBefore(lastNode, nodeBeforeLast);

            var randomNode = new LinkedListNode<string>("third");

            var randomSecondNode = new LinkedListNode<string>("fourth");

            linkedList.AddAfter(lastNode, randomNode);

            linkedList.AddAfter(lastNode, randomSecondNode);

            linkedList.PrintAllNodes();
        }
    }
}
