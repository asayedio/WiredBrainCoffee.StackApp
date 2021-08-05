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
            var stack = new SimpleStack<double>();
            double sum = 0.0;
            stack.Push(1.2);
            stack.Push(2.3);
            stack.Push(3.5);

            while (stack.Count > 0)
            {
                double item;
                item = stack.Pop();
                Console.WriteLine($"Item is: {item}");
                sum += item;
            }
            Console.WriteLine($"The sum is: {sum}");
        }

        private static void StackStrings()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Ahmed");
            stack.Push("Sayed");
            stack.Push("Sobhy");

            while (stack.Count > 0)
            {
                Console.WriteLine($"Item is: {stack.Pop()}");
            }
        }
    }
}
