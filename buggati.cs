using System;

public interface Volkswagen
{
    void Car();
}

public interface Audi : Volkswagen
{
    void Car();
}

public interface Porsche : Volkswagen
{
    void Car();
}

public interface Lamborghini : Volkswagen
{
    void Car();
}

public class Buggati : Volkswagen, Audi, Porsche, Lamborghini
{
    void Volkswagen.Car()
    {
        Console.WriteLine("Luxury features");
    }

    void Audi.Car()
    {
        Console.WriteLine("Sporty design");
    }

    void Porsche.Car()
    {
        Console.WriteLine("Performance");
    }

    void Lamborghini.Car()
    {
        Console.WriteLine("Speed");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("All the features of Buggati are:");
        Buggati b = new Buggati();
        ((Volkswagen)b).Car();
        ((Audi)b).Car();
        ((Porsche)b).Car();
        ((Lamborghini)b).Car();
    }
}



