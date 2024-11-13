using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Class_1
{
    //Compile-Time(Static) Polymorphism: Achieved using method overloading and operator overloading.
    public class Calculator
    {
        public async Task<int> AddNumbers(int A, int B)
        {
            return A + B;
        }

        public async Task<int> AddNumbers(int A, int B, int C)
        {
            return A + B + C;
        }

        public async Task<int> AddNumbers(int A, int B, int C, int D)
        {
            return A + B + C + D;
        }

        public async Task<double> AddNumbers(double A, double B)
        {
            return A + B;
        }
    }

    public class PolymarphismPracticalLearning
    {
        /*Types of Polymorphism in C#
            Compile-Time(Static) : Achieved using method overloading and operator overloading.
            Run-Time (Dynamic) Polymorphism: Achieved using inheritance and interfaces, often implemented with method overriding.*/

        public async Task StaticPolymorphismExample()
        {
            Calculator calculator = new Calculator();
            int value = await calculator.AddNumbers(1, 2);
            int valueOne = await calculator.AddNumbers(1, 2, 3);
            int valueTwo = await calculator.AddNumbers(1, 2, 4, 5);
            double valuedouble = await calculator.AddNumbers(1, 2);

            IPaymentProcessor paymentProcessor = new DepitCardProcess();
            paymentProcessor.ProcessPayment("Ali", 5000);
        }

        /*Run-Time(Dynamic) Polymorphism: Achieved using inheritance and interfaces, often implemented with method overriding.*/

        public interface IPaymentProcessor
        {
            void ProcessPayment(string Name, double amount);
        }

        public class PaymentProcessor : IPaymentProcessor
        {
            public virtual void ProcessPayment(double amount)
            {
                Console.WriteLine($"Payment Process");
            }

            public virtual void ProcessPayment(string Name, double amount)
            {
                Console.WriteLine($"Payment Process");
            }
        }

        public class CreditCardProcessor : PaymentProcessor
        {
            public override void ProcessPayment(string Name, double amount)
            {
                Console.WriteLine($"Mr/Mrs {Name} your Credit card payment = {amount}");
            }

            public override void ProcessPayment(double amount)
            {
                base.ProcessPayment(amount);
            }
        }

        public class DepitCardProcess : PaymentProcessor
        {
            public override void ProcessPayment(string Name, double amount)
            {
                Console.WriteLine($"Mr/Mrs {Name} your Depit card payment = {amount}");
            }
        }
    }
}