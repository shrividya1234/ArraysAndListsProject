using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int array and populate it with numbers 1-10
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1; 
            }
            
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number); // Add to evens list
                }
                else
                {
                    odds.Add(number); // Add to odds list
                }
            }
            Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }
            /* Create another list of type int
             * Name the list "odds"
             */
            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
