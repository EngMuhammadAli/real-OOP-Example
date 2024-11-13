using System.Threading.Channels;

namespace DataStructure_Algorithm.Class_1
{
    /*Encapsulation is a fundamental concept in object-oriented programming that involves bundling data(attributes) and methods(functions) that operate on the data into a
     * single unit or class. It restricts direct access to some of the object's components, which can prevent unintended interference and misuse.
    Here’s a real-world example using an Online Bank Account:
    Scenario: Online Bank Account
    In an online banking system, we want to manage a bank account with details like the account balance,
    account number, and account holder's name. However, we don’t want users to directly access or modify the balance in an unrestricted way.
    Instead, they should interact with it through defined methods to ensure security and control over operations.
    Step 1: Define the BankAccount Class
    The BankAccount class encapsulates the balance and provides public methods for depositing, withdrawing, and checking the balance, while keeping the balance itself private.*/

    public class EncapsulationExample
    {
        public async Task RunExampleAsync()
        {
            ATMExample atm = new ATMExample();
            Console.WriteLine(" *  WELCOME TO BANK AL HABIB  ");
            Console.WriteLine(" *  MR MUHAMMAD ALI ");
            Console.WriteLine(" *  PLEASE ENTER YOUR PIN:   ");

            if (int.TryParse(Console.ReadLine(), out int pin))
            {
                bool isLoginSuccess = await atm.AuthenticateUserAsync(pin);
                if (isLoginSuccess)
                {
                    ShowMainMenu(atm);
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Authentication failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid PIN.");
            }

            Console.ReadLine();
        }

        private void ShowMainMenu(ATMExample atm)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("PLEASE SELECT AN OPERATION:");
                Console.WriteLine("1. CHECK CURRENT BALANCE");
                Console.WriteLine("2. FAST CASH");
                Console.WriteLine("3. CASH WITHDRAWAL");
                Console.WriteLine("4. DEPOSIT");
                Console.WriteLine("5. EXIT");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        atm.DisplayBalance();
                        break;

                    case "2":
                        atm.DisplayFastCashOptions();
                        break;

                    case "3":
                        Console.Write("Enter Withdrawal Amount: ");
                        if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                        {
                            atm.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;

                    case "4":
                        Console.Write("Enter Deposit Amount: ");
                        if (double.TryParse(Console.ReadLine(), out double depositAmount))
                        {
                            atm.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Thank you for using Bank Al Habib ATM. Goodbye!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }

    public class ATMExample
    {
        private double balance = 190000;
        private const int ValidPin = 123;

        public async Task<bool> AuthenticateUserAsync(int pin)
        {
            Console.WriteLine("Authenticating user...");
            await Task.Delay(1000);
            if (pin == ValidPin)
            {
                Console.WriteLine("Authentication successful.");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Bank Al Habib ATM: Current Balance: ${balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Bank Al Habib ATM: Withdrawn ${amount}. New Balance: ${balance}");
                Console.WriteLine("Please collect your cash.");
            }
            else
            {
                Console.WriteLine("Bank HBL: Insufficient funds.");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Bank HBL: Deposited ${amount}. New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void DisplayFastCashOptions()
        {
            Console.WriteLine("Select Fast Cash Amount:");
            Console.WriteLine("1. 1000");
            Console.WriteLine("2. 2000");
            Console.WriteLine("3. 3000");
            Console.WriteLine("4. 4000");
            Console.WriteLine("5. 5000");
            Console.WriteLine("6. 10000");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                double[] fastCashOptions = { 1000, 2000, 3000, 4000, 5000, 10000 };
                if (choice > 0 && choice <= fastCashOptions.Length)
                {
                    Withdraw(fastCashOptions[choice - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please select a valid amount.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}