using System;
using System.Linq;

namespace AuthorStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AuthorRepo();
            var authors = repo.GetAuthors();
            //Console.WriteLine($"There are {authors.Count()} total authors");
            //Console.WriteLine($"with {authors.SelectMany(a => a.Books).Count()} total books");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("How many books are collaborations (have more than one author)?");
            var collaborationsBooks = authors
                                        .SelectMany(a => a.Books)
                                        .GroupBy(bookId => bookId.ID)
                                        .Where(book => book.Count() > 1)
                                        .Select(b => b)
                                        .ToList();
                                        
            Console.WriteLine($"{collaborationsBooks.Count()} books are collaborations.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Which book has the most authors (and how many)?");
            
            var bookAuthors = authors
                                    .SelectMany(a => a.Books)
                                    .GroupBy(b => b.ID)
                                    .OrderBy(book => book.Count() > 1)
                                    .ToList()
                                    .LastOrDefault();

            var bookMostAuthors = bookAuthors
                                .Select(book => book.Title)
                                .FirstOrDefault();
            var numberOfAuthrs = bookAuthors.Count();


            Console.WriteLine($"Book with the most authors is {bookMostAuthors}, from {numberOfAuthrs} authors.");
           
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("What author wrote most collaborations?");

            var authorAndBooksId = authors
                            .SelectMany(a => a.Books.Select(b => new
                            {
                                bookId = b.ID,
                                bookTitle = b.Title,
                                authorId = a.ID,
                                authorName = a.Name
                            }));
            var authorMostColl = authorAndBooksId
                                    .GroupBy(ab => ab.bookId)
                                    .Where(g => g.Count() > 1)
                                    .SelectMany(g => g)
                                    .GroupBy(ab => ab.authorId)
                                    .OrderByDescending(g => g.Count())
                                    .FirstOrDefault();
            var authorMostCollaborations = authorMostColl.First();

            Console.WriteLine($"The author with most collaboration books is {authorMostCollaborations.authorName} with {authorMostColl.Count()} books.");








            Console.ReadLine();
        }

    }
}
