using _3.__List_of_Custom_Objects;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<string> inputList = new List<string>();
            Console.WriteLine("I want you to type with spaces in between information about each product you want to add, example 'Apple 4.99 10' and when you are done just type 'stop' ");
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                inputList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();



                string name = inputList[0];

                double price = double.Parse(inputList[1]);

                int quality = int.Parse(inputList[2]);



                Product newProduct = new Product( name,  price,  quality);

                products.Add(newProduct);
            }

            Console.WriteLine("Now i want you to give me quantity with which i will print every product that is below that qunaitty!");
            int quantityBelow = int.Parse(Console.ReadLine());
            foreach (var product in products)
            {
                if (product.Quantity < quantityBelow)
                {
                    Console.WriteLine($"{product.Name} {product.Price} {product.Quantity}");
                }
            }

            Console.WriteLine("Now i want you to give me a percentage with wich i will increase the price of each product! The percantage must be in WHOLE NUMBERS(INT)!");
            int percentage = int.Parse(Console.ReadLine());

            Console.WriteLine("Old Price: ");
            foreach (var product in products)
            {
                Console.WriteLine(product.Price);
            }

            for (int i = 0; i < products.Count; i++)
            {
                products[i].IncreasePrice(percentage);
            }

            Console.WriteLine("New Price: ");
            foreach (var product in products)
            {
                Console.WriteLine(product.Price);
            }
        }
    }
}