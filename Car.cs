using System;

public class Car{

    // Instance variables
    private double fuelEfficiency; // miles per gallon (mpg)
    private double fuelInTank;     // fuel in tank in litres
    private double totalMiles;     // total miles driven

    // Constant for fuel cost per litre
    private const double FUEL_COST_PER_LITRE = 1.385; // Cost in dollarsv

    // Constructor to initialize the Car object
    public Car(double fuelEfficiency)
    {
        this.fuelEfficiency = fuelEfficiency;
        this.fuelInTank = 0.0;    // Initial fuel in tank is 0
        this.totalMiles = 0.0;    // Initial total miles driven is 0
    }

    // Method to get the current fuel in the tank
    public double GetFuel()
    {
        return fuelInTank;
    }

    // Method to get the total miles driven
    public double GetTotalMiles()
    {
        return totalMiles;
    }

    // Method to set the total miles driven
    public void SetTotalMiles(double miles)
    {
        totalMiles = miles;
    }

    // Method to print the fuel cost
    public void PrintFuelCost()
    {
        Console.WriteLine($"Cost per litre of fuel: ${FUEL_COST_PER_LITRE}");
        Console.WriteLine();
    }

    // Method to add fuel to the tank and calculate the cost
    public void AddFuel(double litres)
    {
        fuelInTank += litres;
        double cost = litres * FUEL_COST_PER_LITRE;
        Console.WriteLine();
        Console.WriteLine($"Adding {litres} litres of fuel...");
        Console.WriteLine();
        Console.WriteLine($"Fuel Cost: ${cost:F2}");
        Console.WriteLine();
        Console.WriteLine($"Total fuel in tank: {fuelInTank} litres");
        Console.WriteLine();
    }

    // Method to calculate the cost of fuel based on the litres
    public double CalcCost(double litres)
    {
        return litres * FUEL_COST_PER_LITRE;
    }

    // Method to convert gallons to litres
    public double ConvertToLitres(double gallons)
    {
        return gallons * 4.546; // 1 gallon = 4.546 litres
    }

    // Method to simulate driving the car for a certain distance
    public void Drive(double miles)
    {
        double fuelRequired = miles / fuelEfficiency; // gallons required for the trip
        double fuelInLitres = ConvertToLitres(fuelRequired); // convert gallons to litres

        // Check if there's enough fuel in the tank
        if (fuelInTank >= fuelInLitres)
        {
            fuelInTank -= fuelInLitres;
            totalMiles += miles;
            double costOfJourney = CalcCost(fuelInLitres);
            Console.WriteLine();
            Console.WriteLine($"Driving {miles} miles...");
            Console.WriteLine();
            Console.WriteLine($"Fuel Used: {fuelInLitres:F2} litres");
            Console.WriteLine();
            Console.WriteLine($"Cost of Journey: ${costOfJourney:F2}");
            Console.WriteLine();
            Console.WriteLine($"Remaining Fuel: {fuelInTank} litres");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Not enough fuel to complete the journey.");
        }
    }

}