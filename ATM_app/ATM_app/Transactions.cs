using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ATM_app
{
    public class BankAccount
    {
        public int initialBalanace = 1000;
        public int Number { get; }
        public string Owner { get; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumber = 1234567890;
        private List<Transaction> AllTransactions = new List<Transaction>();

        public BankAccount(string owner)
        {

            Owner = owner;
            Number = accountNumber;
            accountNumber++;
            Deposit(initialBalanace, DateTime.Now, "initial balance");
        }
        public void Deposit(decimal amount, DateTime date, string note)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "AMOUNT OF DEPOSIT MUST BE POSITIVE");
            }
            if (amount > 1000000)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "can't deposit more than 1 million");
            }
            var deposit = new Transaction(amount, date, note);
            AllTransactions.Add(deposit);
        }
        public void Withdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "AMOUNT OF WITHDRAWAL MUST BE +VE");
            }
            if (Balance - amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }
        public void Transfer(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "AMOUNT OF WITHDRAWAL MUST BE +VE");
            }
            if (Balance - amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Not sufficient funds for this withdrawal");
            }
            var transfer = new Transaction(-amount, date, note);
            AllTransactions.Add(transfer);
        }
    }


    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            Date = date;
            Note = "Germaine Atm";
        }
    }
}
