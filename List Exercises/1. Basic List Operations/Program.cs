using System;
using System.Collections.Generic;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numbers = new List<int>();
            Console.WriteLine("Now please type in 10 whole numbers (INT)!");

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Printing all numbers:");
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("Printing only the even numbers:");
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"{item}");
                }
            }

            for (int i = 0; i < 10; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"The sum of all numbers is: {sum}");
        }
    }
}