using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            List<string> bookArgs = File.ReadAllLines("input.txt").ToList();

            int inputCount = int.Parse(bookArgs[0]);

            Library myLibrary = new Library();

            myLibrary.Books = new List<Book>();

            bookArgs.RemoveAt(0);

            for (int i = 0; i < inputCount; i++)
            {
                Book currentBook = new Book();

                string[] inputArgs = bookArgs[0].Split(' ');

                currentBook.Author = inputArgs[1];

                currentBook.Price = double.Parse(inputArgs[inputArgs.Length - 1]);

                myLibrary.Books.Add(currentBook);

                bookArgs.RemoveAt(0);
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

            File.WriteAllText("output.txt", String.Empty);

            foreach (KeyValuePair<string, double> author in authorPricing.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                string currentOutput = $"{author.Key} -> {author.Value:F2}" + Environment.NewLine;

                File.AppendAllText("output.txt", currentOutput);
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
