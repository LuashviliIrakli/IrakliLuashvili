namespace SevenSomework
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>();

        public void PrintBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty");
            }
            else
            {
                Console.WriteLine("Books in the library: ");
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
            }
        }

        public int Count
        {
            get { return books.Count; }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("book '{book.Title}' Added to library.");
        }

        public bool RemoveBook(string title)
        {
            var bookToRemove = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("book '{title}' Removed from library.");
                return true;
            }
            else
            {
                Console.WriteLine("book '{title}' could not be found.");
                return false;
            }
        }

        public List<Book> FindBook(string title)
        {
            var foundBooks = books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
            return foundBooks;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 2004));

            library.PrintBooks();

            Console.WriteLine("Count of books in the library: {library.Count}");

            library.RemoveBook("1984");

            library.PrintBooks();

            var foundBooks = library.FindBook("The Great Gatsby");
            Console.WriteLine("\nSearched books 'The Great Gatsby':");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }

            library.RemoveBook("The Catcher in the Rye");

            Console.WriteLine("Count of books in the library: {library.Count}");
        }
    }
}
