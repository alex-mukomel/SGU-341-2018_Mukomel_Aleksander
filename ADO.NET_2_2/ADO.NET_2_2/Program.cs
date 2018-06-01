using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var author = new Author("Steave", "McKeyne", 1968);
            var book = new Book(author, "Boom", 340, "Space",
                new DateTime(1996, 5, 10), new DateTime(1994, 10, 2));
            
            Console.WriteLine("Author: {0} {1}; Year of birth: {2}", author.Name,
                author.LastName, author.Year);
            Console.WriteLine("Book: {0}; {1} pages; Publishing house: {2}; Date of publication: {3}; Date of writing: {4}",
                book.Name, book.NumberOfPages, book.PublishingHouse, book.DateOfPublication, book.DateOfWriting);
        }
    }
}
