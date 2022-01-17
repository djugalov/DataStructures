using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var stackWithEmptyConstructor = new Stack<string>();

            stackWithEmptyConstructor.Push("a");
            stackWithEmptyConstructor.Push("b");

            Console.WriteLine(stackWithEmptyConstructor.Pop());
            Console.WriteLine(stackWithEmptyConstructor.Pop());

            var stackWithGivenCapacity = new Stack<string>(3);

            stackWithGivenCapacity.Push("a");
            stackWithGivenCapacity.Push("b");
            stackWithGivenCapacity.Push("c");
            stackWithGivenCapacity.Push("c"); // Stack will be resized at this step

            Console.WriteLine(stackWithGivenCapacity.Pop());
            Console.WriteLine(stackWithGivenCapacity.Pop());

            var stackWithGivenCollection = new Stack<string>(new List<string> { "a", "b", "c" });

            stackWithGivenCollection.Push("d"); // Stack will be resized at this step

            Console.WriteLine(stackWithGivenCollection.Pop());
            Console.WriteLine(stackWithGivenCollection.Pop());
        }
    }
}
