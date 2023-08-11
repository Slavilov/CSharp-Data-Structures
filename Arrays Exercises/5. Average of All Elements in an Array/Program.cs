using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        float[] array = new float[numberOfInputs];
        float sumOfAllElements = 0;
        float averageOfAllElements = 0;


        Console.WriteLine($"Now type in {numberOfInputs} numbers in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = float.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            sumOfAllElements += array[i];
        }

        averageOfAllElements = sumOfAllElements/ numberOfInputs;

        Console.WriteLine($"The average of all elements is {averageOfAllElements}");


    }
}