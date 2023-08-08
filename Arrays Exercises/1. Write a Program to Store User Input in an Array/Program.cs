using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        string[] array = new string[numberOfInputs];


        Console.WriteLine($"Now type in {numberOfInputs} times in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"array[{i}] = {array[i]}");
        }
    }
}