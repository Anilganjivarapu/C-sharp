using System;

class RemoveValueFromArray
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the values of array:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the value to remove:");
        int aValue = int.Parse(Console.ReadLine());

        int[] result = new int[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != aValue)
            {
                result[j] = arr[i];
                j++;
            }
        }

        Console.WriteLine("The resultant array is:");
        for (int i = 0; i < j; i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}