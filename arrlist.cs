using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Hello");
        list.Add(123);
        list.Add(45.67);

        foreach (object obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}