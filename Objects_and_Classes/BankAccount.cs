using System;
using System.Collections.Generic;
using System.Text;

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
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get 
            {
                decimal balance = 0; 
                foreach(var item in allTransactions) {
                    balance += item.Amount; 
                }

                return balance;
            } 
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>(); 

        public BankAccount(string name, decimal initalBalance)
        {
            this.Owner = name;
            MakeDeposit(initalBalance, DateTime.Now, "Initial Balance");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var desposit = new Transaction(amount, date, note);
            allTransactions.Add(desposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            if (Balance - amount < 0) {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal); 
        }

        public string GetAccountHistory() 
        {
            var report = new StringBuilder(); 

            // Header
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                //rows
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{item.Notes}"); 
            }
            return report.ToString();
        }
    }
}

