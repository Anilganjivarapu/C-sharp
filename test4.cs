using System;

namespace demo2
{
    class test4 : demo1.test3
    {
        public void add1()
        {
            Console.WriteLine("Good bye");
        }

        static void Main(string[] args)
        {
            test4 t = new test4();
            t.Add(); 
            t.add1();
            t.add1();
        }
    }
}

