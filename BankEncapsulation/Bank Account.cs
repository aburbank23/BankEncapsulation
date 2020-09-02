using System;
namespace BankEncapsulation
{
    public class Bank_Account
    {
        public Bank_Account()
        {
        }

        private double balance = 0;

        public void Deposit()
        {
            Console.WriteLine($"Please type deposit amount.");
            var depositAmount = double.Parse(Console.ReadLine());
            balance += depositAmount;
        }

        public double GetBalance()
        {
            Console.WriteLine($"Current balance: {balance}");
            Console.WriteLine($"Have a great day.");
            return balance;
            
        }
    }
}
