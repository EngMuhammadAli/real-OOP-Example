using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Class_1
{
    public class LearnCodeTwo
    {
        //2. Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.

        //Sample Input:
        //53
        //30
        //51
        //Expected Output:

        //6
        //21
        //0
        public void check0ne()
        {
            Console.WriteLine(CheckDeff(53));
            Console.WriteLine(CheckDeff(30));
            Console.WriteLine(CheckDeff(51));
            Console.ReadKey();
        }

        public static int CheckDeff(int value)
        {
            int n = 51;
            if (value > n)
            {
                return (value - n) * 3;
            }
            return value - n;
        }

        public void Solution3()
        {
            //3.Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

            //Sample Input:
            //30, 0
            //25, 5
            //20, 30
            //20, 25
            //Expected Output:

            //True
            //True
            //True
            //False

            Console.WriteLine(Solution3(30, 0));
            Console.WriteLine(Solution3(25, 5));
            Console.WriteLine(Solution3(20, 30));
            Console.WriteLine(Solution3(20, 25));
        }

        public static bool Solution3(int a, int b)
        {
            return a == 30 || b == 30 || (a + b) == 30;
        }

        public void Solution4()
        {
            Console.WriteLine(Solution4("if else"));
            Console.WriteLine(Solution4("else"));
            Console.ReadKey();
        }

        public static string Solution4(string input)
        {
            if (input.StartsWith("if"))
            {
                return input;
            }
            return "if " + input;
        }

        public void Solution6()
        {
            //6.Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.

            //Sample Input:
            //"Python", 1
            //"Python", o
            //"Python", 4
            //Expected Output:

            //Pthon
            //ython
            //Pythn
            string input = "Python";
            string input2 = "Python";
            string input3 = "Python";

            Console.WriteLine(RemoveCharAt(input, 1));
            Console.WriteLine(RemoveCharAt(input2, 0));
            Console.WriteLine(RemoveCharAt(input3, 4));
            Console.ReadKey();
        }

        public static string RemoveCharAt(string input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            return input.Remove(index, 1);
        }

        public void Solution7()
        {
            Console.WriteLine(Solution7("C Sharp"));
            Console.WriteLine(Solution7("JS"));
            Console.WriteLine(Solution7("a"));
            Console.ReadLine();
        }

        public static string Solution7(string input)
        {
            string copy;
            if (input.Length > 2)
            {
                string Original = input.Split(' ')[0];
                return copy = string.Concat(Enumerable.Repeat(Original, 4));
            }
            return input;
        }
    }
}