using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("input.txt", String.Empty);

            //Replace String.Empty with your input arguments.

            List<string> bookArgs = File.ReadAllLines("input.txt").ToList();

            int inputCount = int.Parse(bookArgs[0]);

            Library myLibrary = new Library
            {
                Books = new List<Book>()
            };

            bookArgs.RemoveAt(0);

            for (int i = 0; i < inputCount; i++)
            {
                Book currentBook = new Book();

                string[] inputArgs = bookArgs[0].Split(' ');

                currentBook.Name = inputArgs[0];

                currentBook.ReleaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                myLibrary.Books.Add(currentBook);

                bookArgs.RemoveAt(0);
            }

            DateTime releaseFlag = DateTime.ParseExact(bookArgs[0], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> books = new Dictionary<string, DateTime>();

            foreach (Book book in myLibrary.Books)
            {
                if (!books.ContainsKey(book.Name))
                {
                    books.Add(book.Name, book.ReleaseDate);
                }
                else
                {
                    books[book.Name] = book.ReleaseDate;
                }

            }

            File.WriteAllText("output.txt", String.Empty);

            foreach (KeyValuePair<string, DateTime> book in books.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (book.Value > releaseFlag)
                {
                    string currentOutput =
                        $"{book.Key} -> {book.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}"
                        + Environment.NewLine;

                    File.AppendAllText("output.txt", currentOutput);
                }
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
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
