using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Reflection;

namespace DataStructure_Algorithm.Class_1
{
    public class Class_One
    {
        public void SolutionOne()
        {
            int[] numbers = { 3, 5, 1, 9, 2 };
            Console.WriteLine(FindMax(numbers));  // Output: 9
            Console.ReadLine();
        }

        public static int FindMax(int[] input)
        {
            int max = input[0];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > max)
                {
                    max = input[i];
                }
            }
            return max;
        }

        public void SolutionTwo()
        {
            int[] numbers = { 2, 5, 7 };
            var find = numbers.Where(x => x.Equals(5));
            foreach (var num in find)
            {
                Console.WriteLine(num);
            }
            SolutionTwo(numbers);
            Console.ReadLine();
        }

        public static void SolutionTwo(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            var sortedNumbers = numbers.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < sortedNumbers.Length; i++)
            {
                Console.WriteLine(sortedNumbers[i]);
            }
            Console.ReadLine();
        }

        public void SolutionThree()
        {
            int[] numbers = { 2, 2, 3 };
            int[] number = { 1, 2, 3 };
            SolutionThree(number, numbers);
        }

        public static void SolutionThree(int[] inputA, int[] inputB)
        {
            int duplicate = 0;
            for (int i = 0; i < inputA.Length; i++)
            {
                for (int j = 0; j < inputB.Length; j++)
                {
                    if (inputA[i] == inputB[j])
                    {
                        duplicate = +j;
                    }
                }
            }
            Console.WriteLine(duplicate);
            Console.ReadLine();
        }

        public void SolutionFour()
        {
            int[] ints = { 1, 2, 3, 4, 5 };
            int[] number = { 1, 2, 3, 8, 5 };
            SolutionFour(ints, number);
        }

        public static void SolutionFour(int[] InputA, int[] InputB)
        {
            List<int> duplicate = new List<int>();

            for (int i = 0; i < InputA.Length; i++)
            {
                for (int j = 0; j < InputB.Length; j++)
                {
                    if (InputA[i] == InputB[j] && !duplicate.Contains(InputA[i]))
                    {
                        // Add the value itself, not the index
                        duplicate.Add(InputA[i]);
                        break; // Exit inner loop when a duplicate is found
                    }
                }
            }

            // Print the duplicate values
            foreach (var item in duplicate)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public void SolutionFive()
        {
            //2.Write a C# Sharp program to read n values in an array and display them in reverse order.
            //Test Data :
            //Input the number of elements to store in the array :3
            //Input 3 number of elements in the array :
            //element - 0 : 2
            //element - 1 : 5
            //element - 2 : 7
            //Expected Output:
            //The values store into the array are:
            //            2 5 7
            //The values store into the array in reverse are :
            //7 5 2
            int[] number = { 2, 4, 7 };
            SolutionFive(number);
        }

        public static void SolutionFive(int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

            var sortOrder = input.OrderByDescending(x => x).ToArray();
            foreach (var item in sortOrder)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void SolutionSix()
        {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            SolutionSix(number);
        }

        public static void SolutionSix(int[] input)
        {
            int[] copiedArray = (int[])input.Clone();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Orginal Array {i}");
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"Copy Array {i}");
            }
            Console.ReadKey();
        }

        public void SolutionSeven()
        {
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int max = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] > max)
                {
                    max = ints[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public void SolutionEight()
        {
            int[] ints = new int[] { 10, 2, 3, 4, 5, 1, 7, 8, 5, 9, 6 };

            int Min = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if (ints[i] < Min)
                    Min = ints[i];
            }
            Console.WriteLine(Min);
            Console.ReadKey();
        }

        public void SolutionNine()
        {
            int[] ints = new int[] { 10, 2, 3, 4, 5, 1, 7, 8, 5, 9, 6 };

            var SortArray = ints.Order();
            foreach (var item in SortArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void SolutionTen()
        {
            int[] array1 = { 10, 2, 3, 4, 5, 1, 7, 8, 5, 9, 6 };
            int[] array2 = { 10, 13, 3, 4, 5, 1, 7, 8, 5, 9, 6 };
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    for (int j = 0; j < array2.Length; j++)
            //    {
            //        if (array1[i] == array2[j])
            //        {
            //            list.Add(j);
            //        }
            //    }
            //}
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            HashSet<int> element = new HashSet<int>(array1);
            foreach (var num in array2)
            {
                if (element.Contains(num))
                {
                    list.Add(num);
                }
                list2.Add(num);
            }
            foreach (var num in list)
            {
                Console.WriteLine($"ExsistBothList {num}");
            }
            foreach (var num in list2)
            {
                Console.WriteLine($"NotExsistBothList {num}");
            }
            Console.ReadKey();
        }

        public void SolutionElevin()
        {
            int[] ints = new int[] { 10, 2, 3, 4, 5, 1, 7, 8, 5, 9, 6 };
            int[] ints1 = new int[] { 10, 13, 3, 4, 5, 1, 7, 8, 5, 9, 6 };
            List<int> list = new List<int>();

            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints1.Length; j++)
                {
                    if (ints[i] != ints1[j])
                    {
                        list.Add(j);
                    }
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void SolutionElevin2()
        {
            /* 7.Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
             Test Data :
             Input the number of elements to be stored in the first array: 3
             Input 3 elements in the array :
             element - 0 : 1
             element - 1 : 2
             element - 2 : 3
             Input the number of elements to be stored in the second array: 3
             Input 3 elements in the array:
             element - 0 : 1
             element - 1 : 2
             element - 2 : 3
             Expected Output:
             The merged array in ascending order is :
             1 1 2 2 3 3*/
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
            List<int> list = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] == array1[i])
                    {
                        list.Add(array1[i]);
                        list.Add(array2[j]);
                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public void SolutionElevin3()
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            List<int> list = new List<int>();
            int[] array = { 1, 2, 3, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                int index = Array.IndexOf(array, array[i]);
                Console.WriteLine(index);
                keyValuePairs.Add(i, array[i]);
            }

            foreach (var pair in keyValuePairs)
            {
                Console.WriteLine($"Index: {pair.Key}, Value: {pair.Value}");
            }

            Console.ReadKey();
        }

        public void SolutionElevin4()
        {
            string[] strings = { "Ali", "Azhar Bhai", "Mazhar Bhai" };

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            int index = 0;
            var name = strings.Where(x => x.Contains("Azhar Bhai"));
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == "Azhar Bhai")
                {
                    index = Array.IndexOf(strings, strings[i]);
                    keyValuePairs.Add(i, strings[i]);
                }
            }
            Console.WriteLine(index);
            foreach (var pair in keyValuePairs)
            {
                Console.WriteLine($"Index: {pair.Key}, Value: {pair.Value}");
            }

            //with out loop
            string Name = "Azhar Bhai";
            Console.WriteLine($"Name = {Name} Index in array  = {Array.IndexOf(strings, Name)}");

            Console.ReadKey();
        }
    }
}