using System;

namespace App
{
    public static class Demo
    {
        public static void Display()
        {
            Console.WriteLine("In class Demo");
        }
    }

    class Sample2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Good Afternoon");
            Demo.Display();
        }
    }
}