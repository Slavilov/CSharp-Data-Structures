using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfInputs];
        bool isItSorted = false;


        Console.WriteLine($"Now type in {numberOfInputs} numbers, WHOLE NUMBERS (int) in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < array.Length; i++)
        {
            if (array[-1 + 1] > array[i])
            {
                isItSorted = false;
                break;
            }
            else
            {
                isItSorted = true;
            }
        }

        if (isItSorted == true)
        {
            Console.WriteLine("The array is sorted!");
        }
        else
        {
            Console.WriteLine("The array isn't sorted!");
        }

    }
}