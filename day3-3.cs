using System;

namespace StringToDoubleConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a double value: ");
            string input = Console.ReadLine();

            double doubleValue = double.Parse(input);

            Console.WriteLine($"Double value entered: {doubleValue}");
        }
    }
}
