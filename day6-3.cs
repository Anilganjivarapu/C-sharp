using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of people: ");
        int numPeople = int.Parse(Console.ReadLine());

        Console.Write("Enter the age of each person: ");
        string[] agesInput = Console.ReadLine().Split(' ');
        int[] ages = new int[numPeople];
        for (int i = 0; i < numPeople; i++)
        {
            ages[i] = Convert.ToInt32(agesInput[i]);
        }

        int maxAge = ages[0];
        int minAge = ages[0];
        for (int i = 1; i < numPeople; i++)
        {
            if (ages[i] > maxAge)
            {
                maxAge = ages[i];
            }
            if (ages[i] < minAge)
            {
                minAge = ages[i];
            }
        }

        Console.WriteLine("Maximum age: " + maxAge);
        Console.WriteLine("Minimum age: " + minAge);
    }
}