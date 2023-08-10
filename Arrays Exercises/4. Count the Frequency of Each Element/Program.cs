using System.Collections.Generic;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please type in what size of an array you want to create!");
        int numberOfInputs = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfInputs];
        Dictionary<int, int> frequencyOfEachElement = new Dictionary<int, int>();
        //int sumOfAllElements = 0;


        Console.WriteLine($"Now type in {numberOfInputs} numbers, WHOLE NUMBERS (int) in the created array!");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (frequencyOfEachElement.ContainsKey(array[i]))
            {
                frequencyOfEachElement[array[i]]++;
            }
            else
            {
                frequencyOfEachElement.Add(array[i], 1);
            }
        }

        foreach (var item in frequencyOfEachElement)
        {
            Console.WriteLine($"Element {item.Key} occurs in the array {item.Value} time/s!");
        }
        //Console.WriteLine($"The largest number in the array is {sumOfAllElements}");


    }
}