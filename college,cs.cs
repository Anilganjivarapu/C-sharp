using System;

public abstract class Student
{
    public abstract void CalculateMarksAndPercentage();
}

public class CollegeStudent : Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int MathMarks { get; set; }
    public int ScienceMarks { get; set; }
    public int EnglishMarks { get; set; }

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Student Age: " + Age);
    }

    public override void CalculateMarksAndPercentage()
    {
        int totalMarks = MathMarks + ScienceMarks + EnglishMarks;
        double percentage = (totalMarks / 300.0) * 100;

        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CollegeStudent student = new CollegeStudent
        {
            Name = "John Doe",
            Age = 20,
            MathMarks = 80,
            ScienceMarks = 70,
            EnglishMarks = 90
        };

        student.DisplayStudentDetails();
        student.CalculateMarksAndPercentage();

        Console.ReadLine();
    }
}