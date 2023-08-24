using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        var testDictionary = new Dictionary<string, string>
        {
            ["1"] = "One",
            ["2"] = "Two",
            ["3"] = "Three",
            ["4"] = "Three",
            ["5"] = "Five",
            ["6"] = "Six",
            ["7"] = "Seven",
            ["8"] = "Eight"
        };

        var invertedDictionary = new Dictionary<string, List<string>>();

        InvertDictionary(testDictionary, invertedDictionary);
    }

    private static void InvertDictionary(Dictionary<string, string> testDictionary, Dictionary<string, List<string>> invertedDictionary)
    {
        string valueToKey = string.Empty;
        string keyToValue = string.Empty;

        for (int i = 0; i>= testDictionary.Count; i++)
        {
        }

        foreach (var pair in testDictionary)
        {
            valueToKey = pair.Value;
            keyToValue = pair.Key;

            if (invertedDictionary.ContainsKey(valueToKey))
            {
                invertedDictionary[valueToKey].Add(keyToValue);
            }
            else
            {
                invertedDictionary.Add(valueToKey, new List<string>());
                invertedDictionary[valueToKey].Add(keyToValue);
            }
        }

        Console.WriteLine("The original Dictionary is: ");
        foreach (var item in testDictionary)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }

        Console.WriteLine("The inverted Dictionary is: ");
        foreach (var item in invertedDictionary)
        {
            Console.WriteLine($"{item.Key} -> {string.Join(", ", item.Value)}");
        }
    }
}