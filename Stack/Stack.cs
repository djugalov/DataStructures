using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack<T> where T : class
    {
        private const int DefaultCapacity = 32;

        private T[] items;

        private int index;

        public Stack()
        {
            items = new T[DefaultCapacity];
            index = 0;
        }

        public Stack(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                items = new T[capacity];
                index = 0;
            }
        }

        public Stack(IEnumerable<T> initialState)
        {
            items = new T[initialState.Count()];

            Array.Copy(initialState.ToArray(), 0, items, 0, initialState.Count());

            index = initialState.Count();
        }

        //Push
        public void Push(T item)
        {
            if (index == items.Length)
            {
                ResizeArray();
            }

            items[index] = item;

            index++;
        }

        //Pop
        public T Pop() => index == 0 ? throw new InvalidOperationException("Stack is empty") : items[--index];

        //Peek
        public T Peek() => index == 0 ? throw new InvalidOperationException("Stack is empty") : items[index - 1];

        private void ResizeArray()
        {
            var resizedArray = new T[items.Length * 2];

            Array.Copy(items, 0, resizedArray, 0, index);

            items = resizedArray;
        }
    }
}
