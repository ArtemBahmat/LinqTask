using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Task22
    {
        public static Dictionary<string, int> GetPairsAuthorAndBookCount()
        {
            IEnumerable<Book> books = Initializer.GetNewLibrary();
            var result = books.Select(book => book.Author).GroupBy(
                author => author,
                (key, value) => new
                {
                    Author = key,
                    BooksCount = value.Count()
                }
                ).ToDictionary(x => x.Author, x => x.BooksCount);

            return result;
        }
    }
}
