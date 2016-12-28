using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Task11
    {
        public static IEnumerable<Book> GetLinqAndLeapYearBooks()
        {
            IEnumerable<Book> books = Initializer.GetNewLibrary();
            IEnumerable<Book> requiredBooks = books.Where(book => book.Name.Contains("LINQ") && DateTime.IsLeapYear(book.Year));
            return requiredBooks;
        }


        
    }
}
