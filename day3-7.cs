using System;

namespace SimpleInterestCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the principal amount: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter the rate of interest (in percentage): ");
            double rate = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter the time (in years): ");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = principal * rate * time;

            Console.WriteLine($"Simple Interest: {simpleInterest:F5}");
        }
    }
}
