using System;

class Person
{
    public string Name; 
    public virtual void Propose() { }
}

class Boy : Person
{
    public override void Propose()
    {
        Console.WriteLine(Name + " is proposing...");
    }
}

class Girl : Person
{
    public override void Propose()
    {
        Console.WriteLine(Name + " is responding...");
    }
    public bool Accept;
}

class Marriage
{
    public static Boy Husband;
    public static Girl Wife;
    public static void Marry(Boy boy, Girl girl)
    {
        Husband = boy;
        Wife = girl;
        Console.WriteLine("Marriage between " + Husband.Name + " and " + Wife.Name + " is successful.");
    }
    public static void PrintMarriageStatus()
    {
        Console.WriteLine("Husband: " + Husband.Name);
        Console.WriteLine("Wife: " + Wife.Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Boy b = new Boy();
        Girl g1 = new Girl();
        Girl g2 = new Girl();

        Console.Write("Enter boy's name: ");
        b.Name = Console.ReadLine();

        Console.Write("Enter girl 1's name: ");
        g1.Name = Console.ReadLine();

        Console.Write("Enter girl 2's name: ");
        g2.Name = Console.ReadLine();

        b.Propose();
        g1.Propose();
        g2.Propose();

        Console.Write("Does girl 1 accept? (true/false): ");
        g1.Accept = bool.Parse(Console.ReadLine());

        if (g1.Accept)
        {
            Marriage.Marry(b, g1);
        }
        else
        {
            Marriage.Marry(b, g2);
        } 

        Marriage.PrintMarriageStatus();
    }
}