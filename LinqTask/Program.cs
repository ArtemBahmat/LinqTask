using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
  

    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.1
            IEnumerable<Book> books = Task11.GetLinqAndLeapYearBooks();

            //Task 1.2
            int count = Task12.GetCountCharsFromArray();

            //Task 1.3
            int[] integers = Task13.GetOrderedIntArray();

            // Task 1.4
            Task14.ShowPairsAuthorAndBookCount();

            //Task 2.2.
            Dictionary<string, int> pairs = Task22.GetPairsAuthorAndBookCount();


            Console.ReadLine();
        }

      
    }
}
