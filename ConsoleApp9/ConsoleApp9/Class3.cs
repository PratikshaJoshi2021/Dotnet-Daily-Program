using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9
{
    class Account
    {
        private string name;
        private double balance;
        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance; 
        }
        public double deposit(double depositAmount)
        {
            return balance + depositAmount;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setName(string name)
        {

        }
        public string getName()
        {
            return name; 
        }
        public static void Main(string[] args)
        {
            Account ac = new Account("John", 250.00);
            ac.getBalance();
            Console.WriteLine("Balance:"+ac.getBalance());
        }
    }

    }