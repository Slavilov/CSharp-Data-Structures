using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> testQue = new Queue<string>();

        AddToQueue(testQue);
        RemoveFromQueue(testQue);
        CheckIfEmpty(testQue);
    }


    private static void AddToQueue(Queue<string> testQue)
    {
        while (true)
        {
            Console.WriteLine("Type in a string that you want to be added, type in Stop, to stop adding!");
            while (true)
            {
                string toAdd = Console.ReadLine();
                if (toAdd == "Stop")
                {
                    break;
                }

                testQue.Enqueue(toAdd);
            }
        }
    }

    private static void RemoveFromQueue(Queue<string> testQue)
    {
        Console.WriteLine("Type in how many items you want to be removed from the Queue!");
        int n = int.Parse(Console.ReadLine());

        if (testQue.Count > n)
        {
            for (int i = 0; i < n; i++)
            {
                testQue.Dequeue();
            }
        }
        else
        {
            Console.WriteLine("There aren't that many items inside the Queue! Will proceed to remove everytime!");
            testQue.Clear();
        }
    }

    private static void CheckIfEmpty(Queue<string> testQue)
    {
        if (testQue.Count == 0)
        {
            Console.WriteLine("The Queue is empty! If you want to add something type y/n!");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                AddToQueue(testQue);
            }
        }
        else
        {
            Console.WriteLine("The Queue is not empty! If you want to add or delete something type in Add/Delete!");
            string answer = Console.ReadLine();

            if (answer == "Add")
            {
                AddToQueue(testQue);
            }
            else
            {
                RemoveFromQueue(testQue);
            }
        }
    }
}