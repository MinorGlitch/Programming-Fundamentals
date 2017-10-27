using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            Library myLibrary = new Library
            {
                Books = new List<Book>()
            };

            for (int i = 0; i < inputCount; i++)
            {
                Book currentBook = new Book();

                string[] inputArgs = Console.ReadLine().Split(' ');

                currentBook.Name = inputArgs[0];

                currentBook.ReleaseDate = DateTime.ParseExact(inputArgs[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                myLibrary.Books.Add(currentBook);
            }

            DateTime releaseFlag = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

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

            foreach (KeyValuePair<string, DateTime> book in books.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                if (book.Value > releaseFlag)
                {
                    Console.WriteLine($"{book.Key} -> {book.Value.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }

    class Library
    {
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
