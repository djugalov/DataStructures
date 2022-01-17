using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            var queueWithEmptyConstructor = new Queue<string>();

            queueWithEmptyConstructor.Enqueue("a");
            queueWithEmptyConstructor.Enqueue("b");

            Console.WriteLine(queueWithEmptyConstructor.Dequeue());
            Console.WriteLine(queueWithEmptyConstructor.Peek());
            Console.WriteLine(queueWithEmptyConstructor.Dequeue());

            var queueWithGivenCapacity = new Queue<string>(3);

            queueWithGivenCapacity.Enqueue("a");
            queueWithGivenCapacity.Enqueue("b");
            queueWithGivenCapacity.Enqueue("c");
            queueWithGivenCapacity.Enqueue("c"); // Queue will be resized at this step

            Console.WriteLine(queueWithGivenCapacity.Dequeue());
            Console.WriteLine(queueWithGivenCapacity.Dequeue());

            var queueWithGivenCollection = new Queue<string>(new List<string> { "a", "b", "c" });

            queueWithGivenCollection.Enqueue("d"); // Queue will be resized at this step

            Console.WriteLine(queueWithGivenCollection.Dequeue());
            Console.WriteLine(queueWithGivenCollection.Dequeue());
        }
    }
}
