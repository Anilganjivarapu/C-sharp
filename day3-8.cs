using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the range: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Sequence (Recursive):");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciRecursive(i) + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Fibonacci Sequence (Non-Recursive):");
            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciNonRecursive(i) + " ");
            }
            Console.WriteLine();
        }

        static int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static int FibonacciNonRecursive(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}


