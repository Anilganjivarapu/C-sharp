using System;

class Program
{
    static void Main(string[] args)
    {
        int numEmployees = GetNumEmployees();
        Employee[] employees = new Employee[numEmployees];

        for (int i = 0; i < numEmployees; i++)
        {
            employees[i] = GetEmployeeDetails(i + 1);
        }

        double totalSalary = CalculateTotalSalary(employees);
        Console.WriteLine("Total salary of all employees: "+totalSalary);
    }

    static int GetNumEmployees()
    {
        Console.Write("Enter the number of employees: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static Employee GetEmployeeDetails(int employeeNumber)
    {
        Console.Write("Enter name for employee  "+employeeNumber+" ");
        string name = Console.ReadLine();
        Console.Write("Enter salary for employee"+ employeeNumber+" ");
        double salary = Convert.ToDouble(Console.ReadLine());
        return new Employee(name, salary);
    }

    static double CalculateTotalSalary(Employee[] employees)
    {
        double totalSalary = 0;
        foreach (Employee employee in employees)
        {
            totalSalary += employee.Salary;
        }
        return totalSalary;
    }
}

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}