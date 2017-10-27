using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            Library myLibrary = new Library();

            myLibrary.Books = new List<Book>();

            for (int i = 0; i < inputCount; i++)
            {
                Book currentBook = new Book();

                string[] inputArgs = Console.ReadLine().Split(' ');

                currentBook.Author = inputArgs[1];

                currentBook.Price = double.Parse(inputArgs[inputArgs.Length - 1]);

                myLibrary.Books.Add(currentBook);
            }

            Dictionary<string, double> authorPricing = new Dictionary<string, double>();

            foreach (Book book in myLibrary.Books)
            {
                if (!authorPricing.ContainsKey(book.Author))
                {
                    authorPricing[book.Author] = book.Price;
                }
                else
                {
                    authorPricing[book.Author] += book.Price;
                }
            }

            foreach (KeyValuePair<string, double> author in authorPricing.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Author { get; set; }
        public double Price { get; set; }
    }
}
