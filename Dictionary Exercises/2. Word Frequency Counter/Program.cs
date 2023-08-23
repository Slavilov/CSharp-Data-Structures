using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type in a sentence, a paragraph or a text");
        string text = Console.ReadLine();
        Dictionary<string, int> wordFrequency = new Dictionary<string, int>();
        string[] words = text.Split(new char[] { ',', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        
        foreach (string word in words)
        {
            if (wordFrequency.ContainsKey(word))
            {
                wordFrequency[word]++;
            }
            else
            {
                wordFrequency.Add(word, 1);
            }
        }

        foreach (var word in wordFrequency)
        {
            Console.WriteLine($"Word: {word.Key} appears {word.Value} times in the text!");
        }
    }
}