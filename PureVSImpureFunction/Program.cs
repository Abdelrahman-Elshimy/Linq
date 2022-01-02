using System;
using System.Collections.Generic;

namespace PureVSImpureFunction
{
    // Pure Function 
    /*
     * 1 - Easy to test
     * 2 - doesn't change in global variables so it no have a side effect
     * 
     */
    class Program
    {
        static List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main(string[] args)
        {
            //AddInteger1(23);
            

            var x = 232;
            AddInteger2(ref x);
            Print(numbers);
            Console.WriteLine(x);
        }

        static void Print(List<int> source)
        {
            foreach(int num in source)
            {
                Console.Write($" {num}");
            }
            Console.WriteLine();
        }
        // Impure Function
        static void AddInteger1(int num)
        {
            numbers.Add(num);
        }

        static void AddInteger2(ref int num)
        {
            num++;
            numbers.Add(num);
        }
    }
}
