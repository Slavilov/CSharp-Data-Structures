using System.Threading.Channels;

namespace StackExercises;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();

        ReverseAQueue(queue, stack);

    }

    private static void ReverseAQueue(Queue<string> queue, Stack<string> stack)
    {
        Console.WriteLine("Please type in the elements inside the Queue that you want to be reversed, type in Stop when to stop adding elemetns");
        
        while (true)
        {
            string element = Console.ReadLine();
            if (element == "Stop")
            {
                break;
            }
            else
            {
                queue.Enqueue(element);
            }
        }


        Console.WriteLine("Now we will add the elements to the Stack and after that we will reverse them and add them to the Queue again!");
        for (int i = 0; i < queue.Count; i++)
        {
            stack.Push(queue.Dequeue());
        }    

        for (int i = 0; i < stack.Count; i++)
        {
            queue.Enqueue(stack.Pop());
        }


        Console.WriteLine("The reversed Queue elements are: ");
        foreach (var item in queue)
        {
            Console.WriteLine($"{item}");
        }
    }
}