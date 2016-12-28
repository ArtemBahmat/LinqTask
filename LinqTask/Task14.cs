using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Task14
    {
        public static void ShowPairsAuthorAndBookCount()
        {
            Dictionary<string, int> pairs = Task22.GetPairsAuthorAndBookCount();

            foreach (var item in pairs)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
