using System;


namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ashlynBurbank = new Bank_Account();

            ashlynBurbank.Deposit();

            ashlynBurbank.GetBalance();

        }
    }
}
