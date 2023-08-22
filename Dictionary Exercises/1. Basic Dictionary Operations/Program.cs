using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> countries = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("Enter a country name");
            string country = Console.ReadLine();

            Console.WriteLine("Enter the capital of that country");
            string capital = Console.ReadLine();

            countries.Add(country, capital);
            Console.WriteLine("Do you want to add another country? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "n") break;
        }

        Console.WriteLine("Please remove 1 country!");
        string countryToRemove = Console.ReadLine();
        countries.Remove(countryToRemove);

        if (countries.ContainsKey("Germany"))
        {
            Console.WriteLine("The dictionary contains the country Germany!");
        }
        else
        {
            Console.WriteLine("The dictionary doesn't contain the country Germany!");
        }

        Console.WriteLine("Now we will print all the countries with their capitals!");
        foreach (var country in countries)
        {
            Console.WriteLine($"{country.Key} -> {country.Value}");
        }

    }
}