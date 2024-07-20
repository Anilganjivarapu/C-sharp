using System;
using System.Threading;

class Animal21
{
    static void dog(object n)
    {
        int numLaps = (int)n;
        for (int i = 0; i < numLaps; i++)
        {
            Console.WriteLine("Dog is running lap " + i);
            Thread.Sleep(500);
        }
        Console.WriteLine("Dog finished the race ");
    }

    static void cat(object n)
    {
        int numLaps = (int)n;
        for (int i = 0; i < (int)n; i++)
        {
            Console.WriteLine("Cat is running lap " + i);
            Thread.Sleep(500);
        }
        Console.WriteLine("Cat finished the race ");
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of laps: ");
        int n = int.Parse(Console.ReadLine());
        Thread t1 = new Thread(() => dog(n));
        Thread t2 = new Thread(() => cat(n));
        Console.WriteLine("before starting thread alive="+t1.IsAlive);
        t1.Start();
        Console.WriteLine("after starting thread alive="+t1.IsAlive);

        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("Race finished ....");
    }
}