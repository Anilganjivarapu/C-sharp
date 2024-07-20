using System;

namespace samples
{
    class missimg
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array elements separated by space: ");
            string input = Console.ReadLine();
            string[] numsStr = input.Split(' ');

            int n = numsStr.Length + 1; 
            int totalSum = n * (n + 1) / 2; 
            int arraySum = 0;
            foreach (string numStr in numsStr)
            {
                int num = int.Parse(numStr);
                arraySum += num;
            }

            int missingNumber = totalSum - arraySum;
            Console.WriteLine("The missing number is: "+missingNumber);
        }
    }
}
