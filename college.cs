using System;

public abstract class Learner
{
    public abstract void CalcMarks();
}

public class UniLearner : Learner
{
    public string FName;
    public int Age;
    public int Math;
    public int Sci;
    public int Eng;

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + FName);
        Console.WriteLine("Age: " + Age);
    }

    public override void CalcMarks()
    {
        int total = Math + Sci + Eng;
        double perc = (total / 300.0) * 100;

        Console.WriteLine("Total: " + total);
        Console.WriteLine("Percentage: " + perc + "%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        UniLearner learner = new UniLearner
        {
            FName = "Anil",
            Age = 20,
            Math = 100,
            Sci = 100,
            Eng = 100
        };

        learner.ShowDetails();
        learner.CalcMarks();
    }
}