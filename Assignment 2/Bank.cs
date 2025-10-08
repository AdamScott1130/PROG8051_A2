using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Bank
    {
        List<Account> accounts;
        public Bank()
        {
            accounts = new List<Account>();
            // Populate accounts with 10 default accounts
            for(int i = 0; i < 10; i++)
            {
                accounts.Add(new Account("Holder-"+i, 100+i, 0.03f, 100f));
            }
        }

        public Account GetAccount(int AccountNumber)
        {
            for (int i = 0; i < this.accounts.Count(); i++)
            {
                if (accounts[i].GetAccountNumber() == AccountNumber)
                {
                    return accounts[i];
                }
            }
            return null;
        }
        public void OpenAccount()
        {
            this.accounts.Add(new Account());
        }
    }
}
