using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Account
    {
        string AcctHolderName;
        int AcctNo;
        float AnnualIntrRate;
        float Balance;

        public Account(string InitName, int InitNo, float InitRate, float InitBalance) 
        {
            this.AcctHolderName = InitName;
            this.AcctNo = InitNo;
            this.AnnualIntrRate = InitRate;
            this.Balance = InitBalance;
        }

        float Deposit(float Value)
        {
            return 0.0f;
        }

        float Withdraw(float Value)
        {
            return 0.0f;
        }

        public string GetAccountHolderName()
        {
            return "";
        }
        public int GetAccountNumber()
        {
            return 0;
        }
        public float GetAnnualInterestRate()
        {
            return 0f;
        }
        public float GetBalance()
        {
            return 0f;
        }
        public float GetMonthlyInterest()
        {
            return 0f;
        }
        public float GetMonthlyInterestRate()
        {
            return 0f;
        }
        public void SetAnnualInterestRate(float IntrRate)
        {

        }

    }
}
