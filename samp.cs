using System;

class Sample23
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an size:");
        int n = int.Parse(Console.ReadLine());
        int[] a1 = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            a1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array elements are:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a1[i]);
        }
    }
}