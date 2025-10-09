using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class AtmApplication
    {
        public static dynamic GetInput(string type, string message, int numOptions = -1)
        {
            dynamic userInput = -1;
            bool validInput = false;
            Console.WriteLine(message);
            
            while (validInput == false)
            {
                try
                {
                    userInput = Console.ReadLine();
                    switch (type)
                    {
                        case "Int":
                            userInput = int.Parse(userInput);
                            if (userInput < 1 || userInput > numOptions)
                            {
                                Console.WriteLine("Enter a valid input!");
                            }
                            else {
                                validInput = true;
                            }
                            break;
                        case "Float":
                            userInput = float.Parse(userInput);
                            validInput = true;
                            break;
                        case "String":
                            validInput = true;
                            break;
                        default:
                            Console.WriteLine("Type not found. Enter a new type:");
                            type = Console.ReadLine();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Enter a valid input!");
                }

            }
            return userInput;
        }

        public AtmApplication() 
        {
            Run();
        }
        static void Run()
        {
            Bank b = new Bank();
            Account currAcct = null;
            int input = -1;
            int acctMenuInput = -1;
            float amount = 0.0f;
            while (input != 3)
            {
                input = GetInput("Int", "Select an option:\n 1. Create Account\n 2. Select Account\n 3. Exit", 3);
                switch(input)
                {
                    case 1:
                        b.OpenAccount();
                        break;
                    case 2:
                        // Prompt user for account number
                        while (currAcct is null){
                            currAcct = b.GetAccount(GetInput("Int", "Enter account number: ", 999999));
                            if (currAcct is null) {
                                Console.WriteLine("No account matching number. Please try again...");
                            }
                        }
                        

                        // Open Account Menu
                        
                        while (acctMenuInput != 5)
                        {
                            acctMenuInput = GetInput("Int", "Select an option:\n 1. Check Balance\n 2. Deposit\n 3. Withdraw\n 4. Display Transactions\n 5. Exit", 5);
                            switch (acctMenuInput)
                            {
                                case 1:
                                    Console.WriteLine("Balance: {0:$0.00}", currAcct.GetBalance());
                                    break;
                                case 2:
                                    amount = GetInput("Float", "Enter deposit amount: ");
                                    currAcct.Deposit(amount);
                                    Console.WriteLine("Deposit successful. New balance: {0:$0.00}", currAcct.GetBalance());
                                    break;
                                case 3:
                                    amount = GetInput("Float", "Enter withdrawl amount: ");
                                    currAcct.Withdraw(amount);
                                    Console.WriteLine("Withdrawl successful. New balance: {0:$0.00}", currAcct.GetBalance());
                                    break;
                                case 4:
                                    currAcct.DisplayRecords();
                                    break;
                                case 5:
                                    break;
                                default:
                                    Console.WriteLine("Unexpected Behaviour"); // Should never reach here with input validation done
                                    break;
                            }
                        }
                        
                        break;
                }
            }
        }
    }
}
