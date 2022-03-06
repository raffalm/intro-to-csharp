using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp.Classes
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        {
            get 
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                    balance += transaction.Amount;

                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposite must be positive");
            allTransactions.Add(new Transaction(amount,date,note));
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            if(Balance-amount<0) throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            allTransactions.Add(new Transaction(-amount, date, note));
                
        }
        public string GetAcountHistory()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach(var transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Note}");
            }
            return report.ToString();
        }
    }
}
