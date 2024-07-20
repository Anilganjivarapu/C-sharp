using System;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an Integer: ");
            int inputInt = int.Parse(Console.ReadLine());
            long longValue = inputInt;
            float floatValue = longValue;

            double doubleValue = floatValue;

            Console.WriteLine("After widening values are:");
            Console.WriteLine("Long value: "+longValue);
            Console.WriteLine("Float value:"+floatValue);
            Console.WriteLine("Double value:"+doubleValue);
	   Console.WriteLine(doubleValue.GetType());
	   Console.WriteLine(longValue.GetType());
	   Console.WriteLine(floatValue.GetType());
        }
    }
}
