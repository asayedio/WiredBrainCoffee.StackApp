using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack<T>
    {
        private readonly T[] _items;
        private int topIndex = 0;

        public SimpleStack() => _items = new T[10];
        public int Count => topIndex;
        public void Push(T item) => _items[topIndex++] = item;
        public T Pop() => _items[--topIndex];
    }
}