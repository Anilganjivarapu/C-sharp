using System;

namespace DecimalToIntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a double value: ");
            double originalValue = double.Parse(Console.ReadLine());

            short shortValue = (short)Math.Round(originalValue * 100);
            int intValue = (int)Math.Round(originalValue * 100);

            Console.WriteLine($"Original Value before Casting: {originalValue}");
            Console.WriteLine($"After Type Casting to short: {shortValue}");
            Console.WriteLine($"After Type Casting to int: {intValue}");
        }
    }
}
