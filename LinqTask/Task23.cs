using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTask
{
    class Task23
    {
        public static List<Tuple<int, int>> GetAllPairs(int[] array)
        {
           var result = array.SelectMany((i, j) => array.Select((x, y) =>
            {
                return new Tuple<int, int>(i, x);
            }))
            .ToList();
         
            return result;
        }

        public static List<Tuple<int, int>> GetPairsWithNotEqualNumbers(int[] array)
        {
            var result = GetAllPairs(array).Where(pair => pair.Item1 != pair.Item2).ToList();
            return result;
        }

        public static List<Tuple<int, int>> GetPairsExceptSomePairs(int[] array)
        {
            var allPairs = GetAllPairs(array);
            var result = allPairs.Where((pair, count) => 
                    !allPairs.Take(count).Any(tuple => 
                            (pair.Item1 == tuple.Item2 && pair.Item2 == tuple.Item1))).ToList();
            return result;
        }
    }
}
