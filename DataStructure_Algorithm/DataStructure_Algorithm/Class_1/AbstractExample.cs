using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static DataStructure_Algorithm.Class_1.MCB;

namespace DataStructure_Algorithm.Class_1
{
    /*Abstraction in object-oriented programming is the concept of hiding complex implementation details and showing only the essential features of an object or system.It focuses on exposing only the relevant aspects of an object or class to the outside world, while concealing the internal workings.This allows developers to interact with an object or system in a simplified way, without needing to understand or manage its complexity.
    Key Points of Abstraction:
    Hides Complexity: Abstraction helps to separate the "what" from the "how." Users of an abstracted class or method know what it does, not necessarily how it works.
    Improves Code Manageability: By exposing only essential details, abstraction reduces code clutter, making systems easier to understand, maintain, and extend.
    Achieved Through:
    Abstract Classes and Methods: Define methods without providing an implementation, leaving specific details to be implemented by subclasses.
    Interfaces: Declare methods that any implementing class must define, specifying what actions should be performed without detailing how. Example
    Consider a Car class. A driver doesn’t need to know how the car’s engine works to drive; they just need to know how to start, accelerate, and stop.The Car class abstracts these details by providing simple methods like Start(), Accelerate(), and Stop(), hiding the complex mechanisms of the engine, transmission, etc.
    This abstraction allows the driver to interact with the car in a straightforward way while the car manages the underlying complexity internally.*/

    public class AbstractExample
    {
        public void Example()
        {
            ATM HBL = new HBL();
            HBL.AuthenticationUser(123);
            HBL.WithDraw(200);
            HBL.Deposit(8000);
            HBL.Balance();
        }
    }

    public abstract class ATM
    {
        public abstract void WithDraw(double amount);

        public abstract void Deposit(double amount);

        public abstract double Balance();

        public void AuthenticationUser(int Pin)
        {
            Console.WriteLine("Authenticating user...");
            Task.Delay(1000).Wait();
            Console.WriteLine("authenticar authenticated successfully.");
        }
    }

    public class MCB : ATM
    {
        private double balance = 100000;

        public override double Balance()
        {
            Console.WriteLine($"Bank MCB: Current Balance: ${balance}");
            return balance;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Bank MCB: Deposited ${amount}. New Balance: ${balance}");
        }

        public override void WithDraw(double amount)
        {
            if (balance == 0)
            {
                Console.WriteLine("Bank MCB: Insufficient funds.");
            }
            else if (amount < balance)
            {
                balance = balance - amount;
                Console.WriteLine($"Bank MCB: Withdrawn ${amount}. New Balance: ${balance}");
            }
        }

        public class HBL : ATM
        {
            private double balance = 100000;

            public override double Balance()
            {
                Console.WriteLine($"Bank HBL: Current Balance: ${balance}");
                return balance;
            }

            public override void Deposit(double amount)
            {
                balance += amount;
                Console.WriteLine($"Bank HBL: Deposited ${amount}. New Balance: ${balance}");
            }

            public override void WithDraw(double amount)
            {
                if (balance == 0)
                {
                    Console.WriteLine("Bank HBL: Insufficient funds.");
                }
                else if (amount < balance)
                {
                    balance = balance - amount;
                    Console.WriteLine($"Bank HBL: Withdrawn ${amount}. New Balance: ${balance}");
                }
            }
        }
    }
}