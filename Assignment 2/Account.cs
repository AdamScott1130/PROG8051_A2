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
            // Populate the new account with user-defined data
        {
            this.acctHolderName = AtmApplication.GetInput("String", "Enter account owner name: ");
            this.acctNo = AtmApplication.GetInput("Int", "Enter account number: ", 999999);
            this.annualIntrRate = AtmApplication.GetInput("Float", "Enter annual interest rate: ");
            this.balance = AtmApplication.GetInput("Float", "Enter account balance: ");
            this.records = new List<string>();
            Console.WriteLine("Account created with owner {0}, account number {1}, annual interest rate {2:P2}, balance {3:$0.00}.", this.acctHolderName, this.acctNo, this.annualIntrRate, this.balance);

        }
        public Account(string InitName, int InitNo, float InitRate, float InitBalance)
            // Populate the account with predetermined data (used for generating the ten default accounts)
        {
            this.acctHolderName = InitName;
            this.acctNo = InitNo;
            this.annualIntrRate = InitRate;
            this.balance = InitBalance;
            records = new List<string>();
        }

        public float Deposit(float Value)
        {
            // Add value to balance and create a record of the transaction
            this.balance += Value;
            this.records.Add($"Deposit {Value:$0.00}. New balance: {this.balance:$0.00}");
            return this.balance;
        }

        public float Withdraw(float Value)
        {
            // Subtract value from balance and create a record of the transaction
            this.balance -= Value;
            this.records.Add($"Withdraw {Value:$0.00}. New balance: {this.balance:$0.00}");
            return this.balance;
        }

        public string GetAccountHolderName()
            // Getter for account holder name
        {
            return this.acctHolderName;
        }
        public int GetAccountNumber()
            // Getter for account number
        {
            return this.acctNo;
        }
        public float GetAnnualInterestRate()
            // Getter for interest rate
        {
            return this.annualIntrRate;
        }
        public float GetBalance()
            // Getter for balance
        {
            return this.balance;
        }
        public float GetMonthlyInterest()
            // Calculates month's interest for the account (not used)
        {
            return (this.GetMonthlyInterestRate() * this.GetBalance());
        }
        public float GetMonthlyInterestRate()
            // Calculates month's interest rate for the account (not used)
        {
            return (this.GetAnnualInterestRate() / 12);
        }
        public void SetAnnualInterestRate(float newIntrRate)
        {
            // Modify account's interest rate (not used)
            this.annualIntrRate = newIntrRate;
        }
        public void DisplayRecords()
        {
            // Dislay the transaction records to the user
            foreach (string record in this.records)
            {
                Console.WriteLine(record);
            }
        }

    }
}
