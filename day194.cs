using System;

class Program
{
    static void Main(string[] args)
    {
        int numPeople = GetNumPeople();
        Person[] people = new Person[numPeople];

        for (int i = 0; i < numPeople; i++)
        {
            people[i] = GetPersonDetails(i + 1);
        }

        CelebrateBirthdays(people);
    }

    static int GetNumPeople()
    {
        Console.Write("Enter the number of people: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static Person GetPersonDetails(int personNumber)
    {
        Console.Write($"Enter name for person {personNumber}: ");
        string name = Console.ReadLine();
        Console.Write($"Enter age for person {personNumber}: ");
        int age = Convert.ToInt32(Console.ReadLine());
        return new Person(name, age);
    }

    static void CelebrateBirthdays(Person[] people)
    {
        Console.WriteLine("Celebrating Birthdays:");
        foreach (Person person in people)
        {
            person.CelebrateBirthday();
            Console.WriteLine($"{person.Name} is celebrating their birthday! They are now {person.Age} years old.");
        }
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void CelebrateBirthday()
    {
        Age++;
    }
}