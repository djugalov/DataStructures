using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    public class Queue<T> where T : class
    {
        private const int DefaultCapacity = 32;

        private int topIndex;

        private int bottomIndex;

        private T[] items;

        public Queue()
        {
            items = new T[DefaultCapacity];

            topIndex = 0;

            bottomIndex = 0;
        }

        public Queue(int capacity)
        {
            items = new T[capacity];

            topIndex = 0;

            bottomIndex = 0;
        }

        public Queue(IEnumerable<T> initialState)
        {
            items = new T[initialState.Count()];

            Array.Copy(initialState.ToArray(), 0, items, 0, initialState.Count());

            topIndex = initialState.Count();

            bottomIndex = 0;
        }

        public void Enqueue(T item)
        {
            if(topIndex == items.Length)
            {
                Resize();
            }
            
            items[topIndex] = item;

            topIndex++;
        }

        public T Dequeue()
        {
            if(bottomIndex == topIndex)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var item = items[bottomIndex];

            bottomIndex++;

            return item;
        }

        public T Peek() => bottomIndex == topIndex ? throw new InvalidOperationException("Queue is empty") : items[bottomIndex];

        private void Resize()
        {
            var resizedArray = new T[items.Length * 2];

            Array.Copy(items, 0, resizedArray, 0, topIndex);

            items = resizedArray;
        }
    }
}
