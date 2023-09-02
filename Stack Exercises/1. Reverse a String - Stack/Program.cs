using System.Threading.Channels;

namespace StackExercises;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in a word that you want to be reversed!");
        string word = Console.ReadLine();
        char[] wordToCharArr = word.ToCharArray();
        Stack<char> stack = new Stack<char>();
        char[] reversedString = new char[wordToCharArr.Length];

        for (int i = 0; i < wordToCharArr.Length; i++)
        {
            stack.Push(wordToCharArr[i]);
        }

        for (int i = 0; i < wordToCharArr.Length; i++)
        {
            reversedString[i] = stack.Pop();
        }

        string reversedWord = new string(reversedString);
        Console.WriteLine($"The reversed word is: {reversedWord}");
    }
}