namespace Assignment_2
{
    internal class Bank
    {
        List<Account> accounts;
        public Bank()
        {
            // Create list of accounts
            accounts = new List<Account>();
            // Populate accounts with 10 default accounts
            for(int i = 0; i < 10; i++)
            {
                accounts.Add(new Account("Holder-"+i, 100+i, 0.03f, 100f));
            }
        }

        public Account GetAccount(int AccountNumber)
            // Return Account object corresponding to AccountNumber provided (linear search)
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
            // Creates a new account with user-defined data, adds it to the list of accounts
        {
            this.accounts.Add(new Account());
        }
    }
}
