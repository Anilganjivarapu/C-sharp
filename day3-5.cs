using System;

namespace DecimalToIntegerConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a double value: ");
            double originalValue = double.Parse(Console.ReadLine());

            // Convert to cents (rounded to the nearest cent)
            int centsValue = (int)Math.Round(originalValue * 100);

            Console.WriteLine($"Original Value before Casting: {originalValue}");
            Console.WriteLine($"After Type Casting to int (in cents): {centsValue}");
        }
    }
}
