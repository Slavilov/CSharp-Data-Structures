using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfInputs];


        Console.WriteLine($"Now type in {numberOfInputs} numbers, WHOLE NUMBERS (int) in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int len = array.Length;
        for (int i = 0; i < len - 1; i++)
            for (int j = 0; j < len - i - 1; j++)
                if (array[j] > array[j + 1])
                {
                    // swap arr[j] and arr[j+1]
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array{i} = {array[i]}");
        }
    }
}