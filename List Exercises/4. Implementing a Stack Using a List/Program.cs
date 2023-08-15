using _4._Implementing_a_Stack_Using_a_List;
using System;
using System.Collections.Generic;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack customStack = new Stack();

            Console.WriteLine("Now add as many elements as you want, until you say 'stop'!");

            while(true)
            {
                string element = Console.ReadLine();
                if (element == "stop")
                {
                    break;
                }
                else
                {
                    customStack.Push(element);
                }
            }

            Console.WriteLine("The following elements are in the stack:");
            foreach (var item in customStack.List)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("How many items do you want to 'Pop' out of the stack? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                customStack.Pop();
            }

            Console.WriteLine("The following elements are left in the stack:");
            foreach (var item in customStack.List)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}