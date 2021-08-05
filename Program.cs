using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var simpleStack = new SimpleStack();
            double sum = 0.0;
            simpleStack.Push(1.2);
            simpleStack.Push(2.3);
            simpleStack.Push(3.5);

            while (simpleStack.Count > 0)
            {
                double item;
                item = simpleStack.Pop();
                Console.WriteLine($"Item is: {item}");
                sum += item;
            }
            Console.WriteLine($"The sum is: {sum}");
        }

        private static void StackStrings()
        {
            var simpleStack = new SimpleStack();
            simpleStack.Push("Ahmed");
            simpleStack.Push("Sayed");
            simpleStack.Push("Sobhy");

            while (simpleStack.Count > 0)
            {
                Console.WriteLine($"Item is: {simpleStack.Pop();}");
            }
        }
    }
}
