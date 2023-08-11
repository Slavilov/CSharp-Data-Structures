using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfInputs];
        int elementOne = 0;
        int elementTwo = 0;



        Console.WriteLine($"Now type in {numberOfInputs} times NUMBERS, WHOLE NUMBERS(INT) in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array before reversal: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }

        if (numberOfInputs % 2 == 0)
        {
            for (int i = 0; i < numberOfInputs / 2; i++)
            {
                elementOne = array[(array.Length - 1 ) - i];
                elementTwo = array[i];

                array[i] = elementOne;
                array[(array.Length - 1 ) - i] = elementTwo;
            }
        }
        else
        {
            for (int i = 0; i < (numberOfInputs / 2) + 1; i++)
            {
                elementOne = array[(array.Length - 1) - i];
                elementTwo = array[i];

                array[i] = elementOne;
                array[(array.Length - 1) - i] = elementTwo;
            }
        }

        Console.WriteLine("The array after reversal: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
    }
}