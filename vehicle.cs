using System;

abstract class Vehicle
{
    public abstract void Description(int wheels, string type);
}

class Category : Vehicle
{
    public override void Description(int wheels, string type)
    {
        Console.WriteLine("The number of wheels in a " + type + " are " + wheels);
    }

    public static void Main(string[] args)
    {
        Category category = new Category();
        category.Description(int.Parse(args[0]), args[1]);
    }
}