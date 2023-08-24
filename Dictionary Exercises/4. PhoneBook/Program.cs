using System.Threading.Channels;

namespace MethodsExercise;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> phonebook = new Dictionary<string, int>();
        phonebook = AddToPhonebook(phonebook);


        while (true)
        {
            Console.WriteLine("Now you could Add, Update, Delete or Search for a contact in the phonebook" +
                " just choose which one you want, type Add, Update, Delete or Search for each of the command!");

            string command = Console.ReadLine();

            if(command == "Add")
            {
                AddToPhonebook(phonebook);

            }
            else if (command == "Update")
            {
                UpdatePhonebook(phonebook);
            }
            else if (command == "Delete")
            {
                DeleteFromPhonebook(phonebook);
            }
            else if (command == "Search")
            {
                SearchFromPhonebook(phonebook);
            }
            else
            {
                break;
            }

        }
    }

    private static Dictionary<string, int> AddToPhonebook(Dictionary<string, int> phonebook)
    {
        while (true)
        {
            Console.WriteLine("Please write the name of the person who you want to add in the PhoneBook!");
            string name = Console.ReadLine();
            Console.WriteLine("Please write the number of the person who you want to add in the PhoneBook!");
            string numberAsString = Console.ReadLine();

            if (phonebook == null)
            {
                throw new ArgumentNullException(nameof(phonebook), "Phonebook dictionary cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(numberAsString))
            {
                throw new ArgumentException("Name or phone number cannot be empty.");
            }

            int number = int.Parse(numberAsString);

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"The name {name} already exists in the phonebook. Overwriting the old number.");
            }

            phonebook[name] = number;

            Console.WriteLine("Do you wish to continue adding more people, type y/n!");
            string response = Console.ReadLine();

            if (response == "n")
            {
                Console.WriteLine("The phonebook consists of: ");
                foreach (var person in phonebook)
                {
                    Console.WriteLine($"{person.Key} -> {person.Value}");
                }
                break;
            }

        }

        return phonebook;
    }

    private static Dictionary<string, int> UpdatePhonebook(Dictionary<string, int> phonebook)
    {
        while (true)
        {
            Console.WriteLine("Please write the name of the person who you want to Update in the PhoneBook!");
            string name = Console.ReadLine();
            Console.WriteLine("Please write the number of the person who you want to Update in the PhoneBook!");
            string numberAsString = Console.ReadLine();

            if (phonebook == null)
            {
                throw new ArgumentNullException(nameof(phonebook), "Phonebook dictionary cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(numberAsString))
            {
                throw new ArgumentException("Name or phone number cannot be empty.");
            }

            int number = int.Parse(numberAsString);

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine($"The name {name} has been Updated in the phonebook! The new number is -> {number}");
            }

            phonebook[name] = number;

            Console.WriteLine("Do you wish to continue Updating more contacts, type y/n!");
            string response = Console.ReadLine();

            if (response == "n")
            {
                Console.WriteLine("The phonebook consists of: ");
                foreach (var person in phonebook)
                {
                    Console.WriteLine($"{person.Key} -> {person.Value}");
                }
                break;
            }

        }

        return phonebook;
    }

    private static bool DeleteFromPhonebook(Dictionary<string, int> phonebook)
    {
        Console.WriteLine("Please write the name of the person who you want to Delete from the PhoneBook!");
        string name = Console.ReadLine();

        if (phonebook == null)
        {
            throw new ArgumentNullException(nameof(phonebook), "Phonebook dictionary cannot be null.");
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be empty.");
        }

        if (phonebook.ContainsKey(name))
        {
            phonebook.Remove(name);
            Console.WriteLine($"The name {name} has been removed from the phonebook.");

            Console.WriteLine("The phonebook consists of: ");
            foreach (var person in phonebook)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
            return true;
        }
        else
        {
            Console.WriteLine($"The name {name} does not exist in the phonebook.");

            Console.WriteLine("The phonebook consists of: ");
            foreach (var person in phonebook)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
            return false;
        }
    }

    private static void SearchFromPhonebook(Dictionary<string, int> phonebook)
    {
        while (true)
        {
            Console.WriteLine("Please write the name of the person who you want to Search from the PhoneBook!");
            string name = Console.ReadLine();

            if (phonebook == null)
            {
                throw new ArgumentNullException(nameof(phonebook), "Phonebook dictionary cannot be null.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            if (phonebook.ContainsKey(name))
            {
                int numberOfPerson = phonebook[name];
                Console.WriteLine($"The name {name} exists in the phonebook, hes/hers phone number is {numberOfPerson}.");
            }
            else
            {
                Console.WriteLine($"The name {name} does not exist in the phonebook.");
            }

            Console.WriteLine("Do you wish to continue searching in the phonebook? Type y/n!");
            string response = Console.ReadLine();
            if (response == "n")
            {
                break;
            }
        }
    }

}