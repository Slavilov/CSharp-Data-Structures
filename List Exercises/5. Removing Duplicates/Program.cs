using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now i want you to type with spaces in between every element of a list! ");
            List<string> strings = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine("These are the strings inside the list: ");
            foreach (var item in strings)
            {
                Console.WriteLine($"{item}");
            }

            for (int i = 0; i < strings.Count; i++)
            {
                for (int j = 0; j < strings.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (strings[i] == strings[j])
                    {
                        strings.RemoveAll(x => x == strings[j]);
                    }
                }
            }

            Console.WriteLine("These are the strings inside the list after removing the duplicates: ");
            foreach (var item in strings)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}