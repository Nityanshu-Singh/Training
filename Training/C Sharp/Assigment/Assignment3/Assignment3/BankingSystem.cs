using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    // Custom exception class for insufficient balance
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    // BankingSystem class with deposit, withdraw, and balance methods
    class BankingSystem
    {
        private double balance;

        public BankingSystem(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Current Balance: {balance}");
        }
    }

    class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                BankingSystem account = new BankingSystem(1000);
                account.PrintBalance();
                account.Deposit(500);
                account.PrintBalance();
                account.Withdraw(200);
                account.PrintBalance();
                account.Withdraw(2000); // This will throw InsufficientBalanceException
                account.PrintBalance(); // This line won't be executed
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
              
            }
            Console.Read();
        }
    }
}