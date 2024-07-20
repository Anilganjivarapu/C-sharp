using System;

namespace ShortToCharConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a short value: ");
            short shortValue = short.Parse(Console.ReadLine());

            char charValue = (char)shortValue;

            Console.WriteLine($"Original short value: {shortValue}");
            Console.WriteLine($"Converted char value: {charValue}");
        }
    }
}
