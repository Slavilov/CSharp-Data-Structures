using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        int n = 10;  // Number of binary numbers you want to generate
        queue.Enqueue("1");

        while (n-- > 0)
        {
            string s1 = queue.Dequeue();
            Console.WriteLine(s1);

            string s2 = s1;

            queue.Enqueue(s1 + "0");
            queue.Enqueue(s2 + "1");
        }
    }
}