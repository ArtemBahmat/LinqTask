using System;
using System.Collections.Generic;

namespace LinqTask
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Initializer.GetArrayOfInts();

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

            //Task 2.1.
            int countInts = Task21.AgregateCount(array);
            int max = Task21.AgregateMax(array);
            double average = Task21.AgregateAverage(array);

            //Task 2.3.
            var res1 = Task23.GetAllPairs(array);
            var res2 = Task23.GetPairsWithNotEqualNumbers(array);
            var res3 = Task23.GetPairsExceptSomePairs(array);

            Console.ReadLine();
        }

      
    }
}
