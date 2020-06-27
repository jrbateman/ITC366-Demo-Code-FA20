using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter9
    {
   public class BankAccount
        {
        private double balance;
        public BankAccount()
            {
            balance = 0;
            }
        public BankAccount(double initialAmount)
            {
            balance = initialAmount;
            }
        public void Deposit(double amount)
            {
            balance += amount;
            }
        public double Withdraw(double amount)
            {
            if (balance >= amount)
                {
                balance -= amount;
                return balance;
                }
            else
                return -1.0;
            }
        public double GetBalance()
            {
            return balance;
            }
        }
    }
    }
