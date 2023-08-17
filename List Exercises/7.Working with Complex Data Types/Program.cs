using _7.Working_with_Complex_Data_Types;
using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Console.WriteLine("Now type in the Tittle, Author and Rating of the book with spaces in between them and th rating should be a double number example 5.00! say 'Stop' to stop!");
            while (true)
            {
                List<string> strings = Console.ReadLine().Split(' ').ToList();

                if (strings[0] == "Stop")
                {
                    break;
                }

                Book newBook = new Book(strings[0], strings[1], double.Parse(strings[2]));
                books.Add(newBook);
            }

            Console.WriteLine("These are the books added in the list: ");
            foreach (var book in books)
            {
                Console.WriteLine($"Book name: {book.Tittle} Author: {book.Author} Rating: {book.Rating}");
            }
        }
        public static void PrintBooksByAuthor(List<Book> books, string author)
        {
            foreach (var book in books)
            {
                if (book.Author == author)
                {
                    Console.WriteLine($"Title: {book.Tittle}, Author: {book.Author}");
                }
            }
        }

        public static void PrintBooksWithRatingAbove(List<Book> books, double rating)
        {
            foreach (var book in books)
            {
                if (book.Rating >= rating)
                {
                    Console.WriteLine($"Title: {book.Tittle}, Author: {book.Author}");
                }
            }
        }
    }
}