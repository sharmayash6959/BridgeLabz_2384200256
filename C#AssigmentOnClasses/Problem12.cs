using System;

class BankAccount
{
    // Public Variable
    public string AccountNumber { get; set; }

    // Protected Variable
    protected string AccountHolder;

    // Private Variable
    private double Balance;

    // Constructor
    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    // Public Method to Get Balance
    public double GetBalance()
    {
        return Balance;
    }

    // Public Method to Set Balance
    public void SetBalance(double amount)
    {
        if (amount >= 0)
        {
            Balance = amount;
        }
        else
        {
            Console.WriteLine("Invalid balance amount. Balance cannot be negative.");
        }
    }

    // Method to Display Account Details
    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: "+AccountNumber+", Account Holder: "+AccountHolder+", Balance: "+Balance);
    }
}

// Subclass Demonstrating Access Modifiers
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    // Constructor
    public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
        : base(accountNumber, accountHolder, balance)
    {
        InterestRate = interestRate;
    }

    // Method to Display Savings Account Details
    public void DisplaySavingsDetails()
    {
        Console.WriteLine("Account Number: "+AccountNumber+", Account Holder: "+AccountHolder+", Interest Rate: "+InterestRate+"%");
    }
}

class Problem12
{
    static void Main()
    {
        // Creating BankAccount Object
        BankAccount account1 = new BankAccount("123456789", "Alice Johnson", 5000.00);
        account1.DisplayAccountDetails();
        
        // Modifying Balance
        account1.SetBalance(6000.00);
        Console.WriteLine("Updated Balance: "+account1.GetBalance());

        // Creating SavingsAccount Object
        SavingsAccount savings1 = new SavingsAccount("987654321", "Bob Smith", 10000.00, 3.5);
        savings1.DisplaySavingsDetails();
    }
}