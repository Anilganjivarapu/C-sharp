using System;

public abstract class P
{
    public abstract void D();
}

public class RP : P
{
    public string n;
    public int a;
    public string c;

    public override void D()
    {
        Console.WriteLine("Name: " + n);
        Console.WriteLine("Age: " + a);
        Console.WriteLine("Contact: " + c);
    }
}

public static class JT
{
    public static string jd;
    public static string td;
}

public class RS
{
    public RP p;

    public void ASD()
    {
        Console.WriteLine("Seat allocated and dropping location set.");
    }

    public void MR()
    {
        Console.WriteLine("Enter passenger details:");
        p = new RP();
        Console.Write("Name: ");
        p.n = Console.ReadLine();
        Console.Write("Age: ");
        p.a = int.Parse(Console.ReadLine());
        Console.Write("Contact: ");
        p.c = Console.ReadLine();

        Console.WriteLine("Enter journey details:");
        Console.Write("Journey: ");
        JT.jd = Console.ReadLine();

        Console.WriteLine("Enter ticket details:");
        Console.Write("Ticket: ");
        JT.td = Console.ReadLine();

        ASD();
        p.D();
        Console.WriteLine("Journey: " + JT.jd);
        Console.WriteLine("Ticket: " + JT.td);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var rs = new RS();
        rs.MR();
    }
}