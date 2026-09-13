using System;
using System.Collections.Generic;

namespace LibraryInterview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LibraryDB libraryDb = GetSampleLibraryDb();

            Console.WriteLine("Library Application");
            Console.WriteLine("-------------------");

            Console.WriteLine("\nBorrowers:");

            foreach (var borrower in libraryDb.Borrowers)
            {
                Console.WriteLine($"- {borrower.Name}");
            }

            Console.WriteLine("\nBooks:");

            foreach (var book in libraryDb.Books)
            {
                Console.WriteLine(
                    $"- {book.Title} by {book.Author} | Stock: {book.Stock}");
            }

            Console.WriteLine("\nLibrary data loaded successfully.");

            Console.ReadLine();
        }

        public static LibraryDB GetSampleLibraryDb()
        {
            var book1 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Stock = 3
            };

            var book2 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Stock = 2
            };

            var book3 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "1984",
                Author = "George Orwell",
                Stock = 0
            };

            var book4 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Hobbit",
                Author = "J.R.R. Tolkien",
                Stock = 4
            };

            var book5 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                Stock = 2
            };

            var book6 = new Book
            {
                Id = Guid.NewGuid(),
                Title = "The Alchemist",
                Author = "Paulo Coelho",
                Stock = 3
            };

            var borrower1 = new Borrower
            {
                Id = Guid.NewGuid(),
                Name = "John Smith"
            };

            var borrower2 = new Borrower
            {
                Id = Guid.NewGuid(),
                Name = "Sarah Johnson"
            };

            var borrower3 = new Borrower
            {
                Id = Guid.NewGuid(),
                Name = "Michael Brown"
            };

            var borrowing1 = new Borrowing
            {
                Id = Guid.NewGuid(),
                Borrower = borrower1,
                BorrowedBooks = new List<Book>
                {
                    book1,
                    book2
                },
                BorrowedDate = DateTime.Now.AddDays(-12),
                ReturnedDate = DateTime.Now.AddDays(-5),
                SignedOffBy = "Emma Wilson"
            };

            var borrowing2 = new Borrowing
            {
                Id = Guid.NewGuid(),
                Borrower = borrower2,
                BorrowedBooks = new List<Book>
                {
                    book3
                },
                BorrowedDate = DateTime.Now.AddDays(-4),
                ReturnedDate = null,
                SignedOffBy = "Daniel Thompson"
            };

            var borrowing3 = new Borrowing
            {
                Id = Guid.NewGuid(),
                Borrower = borrower3,
                BorrowedBooks = new List<Book>
                {
                    book5,
                    book6
                },
                BorrowedDate = DateTime.Now.AddDays(-8),
                ReturnedDate = DateTime.Now.AddDays(-2),
                SignedOffBy = "Olivia Martin"
            };

            return new LibraryDB
            {
                Books = new List<Book>
                {
                    book1,
                    book2,
                    book3,
                    book4,
                    book5,
                    book6
                },

                Borrowers = new List<Borrower>
                {
                    borrower1,
                    borrower2,
                    borrower3
                },

                Borrowings = new List<Borrowing>
                {
                    borrowing1,
                    borrowing2,
                    borrowing3
                }
            };
        }
    }

    public class LibraryDB
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }
        public List<Borrowing> Borrowings { get; set; }
    }

    public class Borrowing
    {
        public Guid Id { get; set; }

        public Borrower Borrower { get; set; }

        public List<Book> BorrowedBooks { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime? ReturnedDate { get; set; }

        public string SignedOffBy { get; set; }
    }

    public class Borrower
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Stock { get; set; }
    }
}