using System;

class LeadersInArray
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Leaders in the array:");
        PrintLeaders(arr);
    }

    static void PrintLeaders(int[] arr)
    {
        int n = arr.Length;
        int maxRight = arr[n - 1];
        Console.Write(maxRight + " ");
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] >= maxRight)
            {
                maxRight = arr[i];
                Console.Write(maxRight + " ");
            }
        }
    }
}
