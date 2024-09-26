using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = string.IsNullOrEmpty(accountNumber) ? "Unknown" : accountNumber;
            AccountHolder = string.IsNullOrEmpty(accountHolder) ? "Unknown" : accountHolder;    
            Balance = balance < 0.0 ? 0.0 : balance;
        }

        public string AccountNumber
        { 
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }


        public string AccountHolder
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    _balance = 0.0;
                }

                else
                {
                    _balance = value;
                }
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                _balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (_balance - amount >= 0 && amount > 0)
            {
                _balance -= amount;
            }
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
