using System;

// Object oriented programming for a bank account
// bank account supports the following behaviour: 

// It has a 10-digit number that uniquely identifies the bank account.
// It has a string that stores the name or names of the owners.
// The balance can be retrieved.
// It accepts deposits.
// It accepts withdrawals.
// The initial balance must be positive.
// Withdrawals cannot result in a negative balance.

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Bob", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine($"Account: {account.Balance}");

            // test that the initial balances must be positive. 
            try 
            {
                var invalidAccount =  new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e) 
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            // catch exceptions do not stop the program from entirely running the
            // this line below will still run as proceeded unless there is a return statement inside of the catch block
            account.MakeWithdrawal(20, DateTime.Now, "Phasmophobia");
            Console.WriteLine($"Account: {account.Balance}");

            //test for a negative balance. 
            try 
            {
                account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            } 

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
