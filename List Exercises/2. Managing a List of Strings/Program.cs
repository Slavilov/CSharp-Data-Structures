using System;
using System.Collections.Generic;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true) 
            {
                string nameToAdd = Console.ReadLine();
                if (nameToAdd != "stop")
                {
                    names.Add(nameToAdd);
                }
                else
                {
                    break;
                }
            }

            foreach (var name in names)
            {
                if (name.Contains('a'))
                {
                    Console.WriteLine($"{name}");
                }
            }
        }
    }
}