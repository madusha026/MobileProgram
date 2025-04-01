using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Mobile Phone Example");
        Console.WriteLine();
        // Creating a Mobile object (PayAsYouGo example)
        Mobile myMobile = new Mobile("PayAsYouGo", "iPhone S6", "123-456-7890");

        // Displaying initial Mobile information
        Console.WriteLine("Mobile Details:");
        Console.WriteLine(myMobile.ToString());
        Console.WriteLine();

        // Adding credit
        myMobile.AddCredit(50.00);
        Console.WriteLine();

        // Making a call
        myMobile.MakeCall(5); // 5 minutes
        Console.WriteLine();

        // Sending a text
        myMobile.SendText(3); // 3 texts
        Console.WriteLine();

        // Displaying final Mobile information
        Console.WriteLine("Final Mobile Information:");
        Console.WriteLine(myMobile.ToString());
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");    


        Console.WriteLine("Employee Example");
        Console.WriteLine();
        // Create an Employee object
        Employee emp = new Employee("John Doe", 50000);

        // Display initial employee details
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {emp.GetName()}");
        Console.WriteLine($"Current Salary: {emp.GetSalary()}");
        Console.WriteLine();

        // Raise the salary by 10%
        emp.RaiseSalary(10);

        // Calculate and display the tax
        double tax = emp.Tax();
        Console.WriteLine();
        Console.WriteLine($"Tax Calculation");
        Console.WriteLine($"Tax Deduction: {tax:C}");
        Console.WriteLine($"Salary after tax: {emp.GetSalary()}");
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("Car Example");
        Console.WriteLine();
        Console.WriteLine("Car Details:");
        // Create a Car object with fuel efficiency of 25 mpg
        Car myCar = new Car(25);

        // Print the fuel cost
        myCar.PrintFuelCost();
        

        // Add fuel to the car's tank
        myCar.AddFuel(20); // Adding 20 litres of fuel
        

        // Simulate driving the car for a certain distance
        myCar.Drive(50); // Driving 50 miles
        

        // Check the total miles driven and fuel left
        Console.WriteLine($"Total Miles Driven: {myCar.GetTotalMiles()} miles");
        Console.WriteLine();
        Console.WriteLine($"Fuel Left in Tank: {myCar.GetFuel()} litres");
    }
}
