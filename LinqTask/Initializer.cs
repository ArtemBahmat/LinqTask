using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    static class Initializer
    {
        public static IEnumerable<Book> GetNewLibrary()
        {
            IEnumerable<Book> books = new List<Book>
            {
                new Book { Author = "Ivanov", Name = "Book1", Year = 1950},
                new Book { Author = "Petrov", Name = "Book2 LINQ", Year = 2016},
                new Book { Author = "Sidorov", Name = "Book3 C SHARP", Year = 1976},
                new Book { Author = "Ivanov", Name = "Book4 JAVA", Year = 1980},
                new Book { Author = "Pushkin", Name = "Book5 JS", Year = 1998},
                new Book { Author = "Turgenev", Name = "Book6 C++", Year = 2000},
                new Book { Author = "Ivanov", Name = "Book7 C", Year = 2001},
                new Book { Author = "Sidorov", Name = "Book8 PHP", Year = 2002}
            };

            return books;
        }

        public static string[] GetArrayOfWords()
        {
            string[] words = { "Алекс", "Олег", "Дмитрий", "Сергей", "Ольга", "Катя", "Света" };
            return words;
        }

        public static int[] GetArrayOfInts()
        {
            int[] integers = { 40, 62, 94, 56, 25, 65, 28, 10, 42, 63, 49, 99 };
            return integers;
        }


        
    }
}
