using System;

public class Mobile{

    // Instance variables
    private string accountType;
    private string deviceName;
    private string mobileNumber;
    private double balance;

    // Constants for costs
    const double CALL_COST = 0.10; // Cost per minute for a call
    const double TEXT_COST = 0.05; // Cost per text

    // Constructor to initialize the Mobile object
    public Mobile(string accountType, string deviceName, string mobileNumber)
    {
        this.accountType = accountType;
        this.deviceName = deviceName;
        this.mobileNumber = mobileNumber;
        this.balance = 0.0; // Initial balance set to zero
    }

    // Accessor methods (getters)
    public string GetAccountType()
    {
        return accountType;
    }

    public string GetDeviceName()
    {
        return deviceName;
    }

    public string GetMobileNumber()
    {
        return mobileNumber;
    }

    public double GetBalance()
    {
        return balance;
    }

    // Mutator methods (setters)
    public void AddCredit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Topping up {amount:C}...");
        Console.WriteLine($"New Balance: {balance:C}");
    }

    public void MakeCall(int minutes)
    {
        double cost = minutes * CALL_COST;
        if (balance >= cost)
        {
            balance -= cost;
            Console.WriteLine($"Making a call for {minutes} minutes...");
            Console.WriteLine($"Cost: {cost:C}");
            Console.WriteLine($"New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Not enough credit for this call.");
        }
    }

    public void SendText(int numberOfTexts)
    {
        double cost = numberOfTexts * TEXT_COST;
        if (balance >= cost)
        {
            balance -= cost;
            Console.WriteLine($"Sending {numberOfTexts} text(s)...");
            Console.WriteLine($"New Balance: {balance:C}");
        }
        else
        {
            Console.WriteLine("Not enough credit for this text(s).");
        }
    }

    // ToString method to display the Mobile details
    public override string ToString()
    {
        return $"Account Type: {accountType}\nDevice: {deviceName}\nMobile Number: {mobileNumber}\nCurrent Balance: {balance:C}";
    }

}