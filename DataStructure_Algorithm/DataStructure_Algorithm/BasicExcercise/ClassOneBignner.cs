using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.BasicPrograms
{
    public class ClassOneBignner
    {
        public void Solution1()
        {
            /*
            1.Write a C# Sharp program to print Hello and your name in a separate line.
            Expected Output :
            Hello: Alexandra Abramov*/
            Console.WriteLine("Hello: Alexandra Abramov");
        }

        public void Solution2()
        {
            /*2.Write a C# Sharp program to print the sum of two numbers.8*/
            int A = 1, B = 2;
            Console.WriteLine($"Sum of two numbers = {A + B}");
        }

        public void Solution3()
        {
        }

        public void Solution4()
        {
            /*4. Write a C# Sharp program to print the results of the specified operations.

            Test data:

            -1 + 4 * 6
            ( 35+ 5 ) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2
            Expected Output:
            23
            5
            12
            3*/
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            Console.ReadLine();
        }

        public void Solution5()
        {
            /*5. Write a C# Sharp program to swap two numbers.
            Test Data:
            Input the First Number : 5
            Input the Second Number : 6
            Expected Output:
            After Swapping :
            First Number : 6
            Second Number : 5*/
            int A = 5;
            int B = 6;
            Console.WriteLine("Before...");
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");

            Console.WriteLine($"After ...");
            Task.Delay(1000).Wait();

            int C = A;
            A = B;
            B = C;
            Console.WriteLine($"A = {A}");
            Console.WriteLine($"B = {B}");
        }

        public void Solution6()
        {
            /*
            6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
            Test Data:
            Input the first number to multiply: 2
            Input the second number to multiply: 3
            Input the third number to multiply: 6
            Expected Output:
            2 x 3 x 6 = 36
            */
            Console.WriteLine("Enter first number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entr 3rd number");
            int C = Convert.ToInt32(Console.ReadLine());

            Task.Delay(1000).Wait();

            Console.WriteLine($"Result\n{A * B * C}");
        }

        public void Solution7()
        {
            /*7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
            Test Data:
            Input the first number: 25
            Input the second number: 4
            Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1*/
            Console.WriteLine("input first number");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input second number");
            int B = Convert.ToInt32(Console.ReadLine());
            Task.Delay(1000).Wait();
            Console.WriteLine($"sum of two number = {A + B}");
            Task.Delay(1000).Wait();
            Console.WriteLine($"Sub of two number = {A - B}");
            Task.Delay(1000).Wait();
            Console.WriteLine($"multi of two number = {A * B}");
            Task.Delay(1000).Wait();
            Console.WriteLine($"divide of two number = {A - B}");
            Task.Delay(1000).Wait();
            Console.WriteLine($"module two number = {A % B}");
        }

        public void Solution8()
        {
            /*8. Write a C# Sharp program that prints the multiplication table of a number as input.
            Test Data:*/

            Console.WriteLine("Enter Table number which you want print");
            int tableNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {tableNumber} = {i * tableNumber}");
            }
        }

        public void Solution9()
        {
            /*9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            Test Data:
            Enter the First number: 10
            Enter the Second number: 15
            Enter the third number: 20
            Enter the fourth number: 30*/

            Console.WriteLine("Enter the First number");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number");
            int C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth number");
            int D = Convert.ToInt32(Console.ReadLine());

            int sum = A + B + C + D;

            // Divide by 4 to get the correct average
            double avg = (double)sum / 4;

            Console.WriteLine($"The average is: {avg}");
        }
    }
}