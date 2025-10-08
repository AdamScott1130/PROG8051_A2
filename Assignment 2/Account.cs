using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2;
namespace Assignment_2
{
    internal class Account
    {
        string acctHolderName;
        int acctNo;
        float annualIntrRate;
        float balance;
        List<string> records;


        public Account()
        {
            this.acctHolderName = AtmApplication.GetInput("String", "Enter account owner name: ");
            this.acctNo = AtmApplication.GetInput("Int", "Enter account number: ", 999999);
            this.annualIntrRate = AtmApplication.GetInput("Float", "Enter annual interest rate: ");
            this.balance = AtmApplication.GetInput("Float", "Enter account balance: ");
            records = new List<string>();
            Console.WriteLine("Account created with owner {0}, account number {1}, annual interest rate {2:P2}, balance {3:$0.00}.", this.acctHolderName, this.acctNo, this.annualIntrRate, this.balance);

        }
        public Account(string InitName, int InitNo, float InitRate, float InitBalance) 
        {
            this.acctHolderName = InitName;
            this.acctNo = InitNo;
            this.annualIntrRate = InitRate;
            this.balance = InitBalance;
            records = new List<string>();
        }

        public float Deposit(float Value)
        {
            this.balance += Value;
            this.records.Add($"Deposit {Value:$0.00}. New balance: {this.balance:$0.00}");
            return this.balance;
        }

        public float Withdraw(float Value)
        {
            this.balance -= Value;
            this.records.Add($"Withdraw {Value:$0.00}. New balance: {this.balance:$0.00}");
            return this.balance;
        }

        public string GetAccountHolderName()
        {
            return this.acctHolderName;
        }
        public int GetAccountNumber()
        {
            return this.acctNo;
        }
        public float GetAnnualInterestRate()
        {
            return this.annualIntrRate;
        }
        public float GetBalance()
        {
            return this.balance;
        }
        public float GetMonthlyInterest()
        {
            return (this.GetMonthlyInterest() * this.GetBalance());
        }
        public float GetMonthlyInterestRate()
        {
            return (this.GetAnnualInterestRate() / 12);
        }
        public void SetAnnualInterestRate(float newIntrRate)
        {
            this.annualIntrRate = newIntrRate;
        }


    }
}
