using System;

namespace StockPriceConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the stock price: ");
            double stockPrice = double.Parse(Console.ReadLine());

            float floatPrice = (float)stockPrice;
            long longPrice = (long)stockPrice;
            int intPrice = (int)stockPrice;

            Console.WriteLine("After narrowing values are:");
            Console.WriteLine($"Float value: {floatPrice}");
            Console.WriteLine($"Long value: {longPrice}");
            Console.WriteLine($"Int value: {intPrice}");
        }
    }
}