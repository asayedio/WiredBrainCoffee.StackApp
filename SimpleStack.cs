using System;

namespace WiredBrainCoffee.StackApp
{
    public class SimpleStack
    {
        private readonly double[] _items;
        private int topIndex = 0;

        public SimpleStack() => _items = new double[10];
        public int Count => topIndex;
        public void Push(double item) => _items[topIndex++] = item;
        public double Pop() => _items[--topIndex];
    }
}