using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Country> countries = new List<Country>();

        while (true)
        {
            Console.Write("Enter the name of a country (or 'quit' to finish): ");
            string countryName = Console.ReadLine();
            if (countryName.ToLower() == "quit")
            {
                break;
            }

            Console.Write("Enter the capital of " + countryName + ": ");
            string capital = Console.ReadLine();

            Country country = new Country(countryName, capital);
            countries.Add(country);
        }

        DisplayCountries(countries);
        GenerateQuiz(countries);
    }

    static void DisplayCountries(List<Country> countries)
    {
        Console.WriteLine("Country-Capital Pairs:");
        foreach (Country country in countries)
        {
            Console.WriteLine(country.Name + " - " + country.Capital);
        }
    }

    static void GenerateQuiz(List<Country> countries)
    {
        Console.WriteLine("Quiz:");
        foreach (Country country in countries)
        {
            Console.WriteLine("What is the capital of " + country.Name + "?");
            Console.WriteLine("Answer: " + country.Capital);
        }
    }
}

class Country
{
    public string Name { get; set; }
    public string Capital { get; set; }

    public Country(string name, string capital)
    {
        Name = name;
        Capital = capital;
    }
}