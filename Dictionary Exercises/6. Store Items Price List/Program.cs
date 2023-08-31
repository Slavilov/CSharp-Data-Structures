using System;
using System.Collections.Generic;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> storeItems = new Dictionary<string, double>();
            AddToStore(storeItems);

            while (true)
            {
                Console.WriteLine("Now you can Add, Update, Delete, or View items in the store!" +
                                  " Just choose which one you want, type Add, Update, Delete, or View for each of the commands!");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "Add":
                        AddToStore(storeItems);
                        break;
                    case "Update":
                        UpdateStorePrice(storeItems);
                        break;
                    case "Delete":
                        DeleteFromStore(storeItems);
                        break;
                    case "View":
                        ViewFromStore(storeItems);
                        break;
                    case "Discount":
                        ApplyDiscountToAllItems(storeItems);
                        break;
                    default:
                        return;
                }
            }
        }

        private static void AddToStore(Dictionary<string, double> storeItems)
        {
            while (true)
            {
                Console.WriteLine("Please write the name of the item you want to add to the store:");
                string itemName = Console.ReadLine();
                Console.WriteLine("Please write the price of the item:");
                if (!double.TryParse(Console.ReadLine(), out double price))
                {
                    Console.WriteLine("Invalid price format. Try again.");
                    continue;
                }

                if (storeItems.ContainsKey(itemName))
                {
                    Console.WriteLine($"The item {itemName} already exists in the store. Overwriting the old price.");
                }

                storeItems[itemName] = price;

                Console.WriteLine("Do you wish to continue adding more items? (y/n)");
                if (Console.ReadLine().ToLower() == "n")
                {
                    break;
                }
            }
        }

        private static void UpdateStorePrice(Dictionary<string, double> storeItems)
        {
            Console.WriteLine("Please write the name of the item you want to update:");
            string itemName = Console.ReadLine();

            if (!storeItems.ContainsKey(itemName))
            {
                Console.WriteLine("The item does not exist in the store.");
                return;
            }

            Console.WriteLine("Please write the new price for the item:");
            if (!double.TryParse(Console.ReadLine(), out double newPrice))
            {
                Console.WriteLine("Invalid price format. The item price was not updated.");
                return;
            }

            storeItems[itemName] = newPrice;
            Console.WriteLine($"The price for {itemName} has been updated to {newPrice}");
        }

        private static void DeleteFromStore(Dictionary<string, double> storeItems)
        {
            Console.WriteLine("Please write the name of the item you want to delete from the store:");
            string itemName = Console.ReadLine();

            if (storeItems.ContainsKey(itemName))
            {
                storeItems.Remove(itemName);
                Console.WriteLine($"The item {itemName} has been removed from the store.");
            }
            else
            {
                Console.WriteLine($"The item {itemName} does not exist in the store.");
            }
        }

        private static void ViewFromStore(Dictionary<string, double> storeItems)
        {
            Console.WriteLine("Please write the name of the item you want to view:");
            string itemName = Console.ReadLine();

            if (storeItems.ContainsKey(itemName))
            {
                double price = storeItems[itemName];
                Console.WriteLine($"The price for {itemName} is {price}");
            }
            else
            {
                Console.WriteLine($"The item {itemName} does not exist in the store.");
            }
        }

        private static void ApplyDiscountToAllItems(Dictionary<string, double> storeItems)
        {
            Console.WriteLine("Enter the discount percentage you want to apply (e.g., for 10% discount, enter 10):");

            if (!double.TryParse(Console.ReadLine(), out double discountPercentage) || discountPercentage < 0 || discountPercentage > 100)
            {
                Console.WriteLine("Invalid discount percentage. No changes were made to the prices.");
                return;
            }

            double discountFactor = 1 - (discountPercentage / 100);

            foreach (var key in storeItems.Keys.ToList())
            {
                storeItems[key] *= discountFactor;
            }

            Console.WriteLine($"A discount of {discountPercentage}% has been applied to all items.");
        }

    }
}
