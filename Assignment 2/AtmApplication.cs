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

            dynamic input = -1;
            while (input != 3)
            {
                input = GetInput("Int", "Select an option:\n 1. Create Account\n 2. Select Account\n 3. Exit", 3);
                Console.WriteLine(input);
            }
        }
    }
}
