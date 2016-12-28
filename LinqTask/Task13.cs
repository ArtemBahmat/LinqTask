using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Task13
    {
        public static int[] GetOrderedIntArray()
        {
            int[] integers = Initializer.GetArrayOfInts();
            int[] orderedIntegers = integers.OrderBy(i => i.ToString().First<char>()).ThenByDescending(i => i.ToString().Last<char>()).ToArray();
            return orderedIntegers;
        }
    }
}
