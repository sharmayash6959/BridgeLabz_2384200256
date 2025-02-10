using System;

// Base class: BankAccount
class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Generic Bank Account");
    }
}

// Subclass: SavingsAccount
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(int accountNumber, double balance, double interestRate) 
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }
}

// Subclass: CheckingAccount
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) 
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }
}

// Subclass: FixedDepositAccount
class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; } // in months

    public FixedDepositAccount(int accountNumber, double balance, int maturityPeriod) 
        : base(accountNumber, balance)
    {
        MaturityPeriod = maturityPeriod;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }
}

class BankAccountTypes
{
    static void Main()
    {
        SavingsAccount savings = new SavingsAccount(101, 5000.0, 3.5);
        CheckingAccount checking = new CheckingAccount(102, 2000.0, 1000.0);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount(103, 10000.0, 12);

        savings.DisplayAccountType();
        checking.DisplayAccountType();
        fixedDeposit.DisplayAccountType();
    }
}
