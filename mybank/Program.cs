using System;
using BankyStuffLibrary;
using Humanizer;


namespace mybank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("minhaj", 1000);
            Console.WriteLine($"Congratulations!! Account {account.Number} was created for {account.Owner} with {account.Balance}");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
           // Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
           // Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


        }
    }
}