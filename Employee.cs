using System;

public class Employee{

    // Instance variables
    private string name;
    private double salary;

    // Constructor to initialize the Employee object
    public Employee(string employeeName, double currentSalary)
    {
        this.name = employeeName;
        this.salary = currentSalary;
    }

    // Accessor methods
    public string GetName()
    {
        return name;
    }

    public string GetSalary()
    {
        // Return salary in currency format
        return salary.ToString("C");
    }

    // Method to raise the salary by a given percentage
    public void RaiseSalary(double percentage)
    {
        salary += salary * (percentage / 100);
        Console.WriteLine($"Salary raised by {percentage}%.");
        Console.WriteLine($"New Salary: {GetSalary()}");
    }

    // Method to calculate tax based on salary
    public double Tax()
    {
        double taxAmount = 0;

        // Calculate tax based on the tax brackets
        if (salary <= 18200)
        {
            taxAmount = 0;
        }
        else if (salary <= 37000)
        {
            taxAmount = (salary - 18200) * 0.19;
        }
        else if (salary <= 90000)
        {
            taxAmount = 3572 + (salary - 37000) * 0.325;
        }
        else if (salary <= 180000)
        {
            taxAmount = 20797 + (salary - 90000) * 0.37;
        }
        else
        {
            taxAmount = 54096 + (salary - 180000) * 0.45;
        }

        return taxAmount;
    }

}