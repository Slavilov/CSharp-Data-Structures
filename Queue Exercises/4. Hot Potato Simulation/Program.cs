using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        string[] children = { "Alice", "Bob", "Charlie", "David", "Eva" };
        int countToEliminate = 3; // The number to count to before eliminating a child

        foreach (var child in children)
        {
            queue.Enqueue(child);
        }

        while (queue.Count > 1)
        {
            for (int i = 1; i < countToEliminate; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            Console.WriteLine($"{queue.Dequeue()} is eliminated.");
        }

        Console.WriteLine($"Last child standing is {queue.Dequeue()}");
    }
}
