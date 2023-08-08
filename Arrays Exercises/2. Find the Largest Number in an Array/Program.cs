using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfInputs];
        int largestNumberInArray = int.MinValue;


        Console.WriteLine($"Now type in {numberOfInputs} numbers, WHOLE NUMBERS (int) in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < array.Length; i++)
        {
            if (largestNumberInArray < array[i])
            {
                largestNumberInArray = array[i];
            }
        }

        Console.WriteLine($"The largest number in the array is {largestNumberInArray}");


    }
}