using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.Class_1
{
    public class Example1
    {
        public void Star()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void Star2()
        {
            for (int i = 10; i >= 0; --i)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //public void Star()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        // Print stars on the same line
        //        for (int j = 0; j < i; j++)
        //        {
        //            Console.Write("*");
        //        }
        //        // Move to the next line after each row of stars
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //}
    }
}