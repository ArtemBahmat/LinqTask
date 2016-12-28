using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Task12
    {
        public static int GetCountCharsFromArray()
        {
            string[] words = Initializer.GetArrayOfWords();
            int countChars = words.SelectMany(w => w).Distinct().Count();
            return countChars;
        }
    }
}
