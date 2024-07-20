using System;
class GrandFather
{
    public void Land()
    {
        Console.WriteLine("GrandFather's land");
    }
}

class Father : GrandFather
{
    public void Home()
    {
        Console.WriteLine("Father's home");
    }

    public void Car()
    {
        Console.WriteLine("Father's Car");
    }
}

class Son : Father
{
    public Son()
    {
        Console.WriteLine("Son...");
    }

    public void Mobile()
    {
        Console.WriteLine("Son's mobile");
    }
}

class Daughter : Father
{
    public Daughter()
    {
        Console.WriteLine("Daughter...");
    }

    public void Purse()
    {
        Console.WriteLine("Daughter's purse");
    }
}

public class Test
{
    public static void Main(string[] args)
    {
        var s = new Son();
        s.Land();   
        s.Car();    
        s.Home();   
        s.Mobile();

        
        var d = new Daughter();
        d.Land();   
        d.Car();    
        d.Home();   
        d.Purse();  
        
    }
}
