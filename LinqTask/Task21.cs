using System.Linq;

namespace LinqTask
{
    class Task21
    {
        public static int AgregateCount(int[] array)
        {
            int count = array.Aggregate(0, (result, next) => result + 1);
            return count;
        }

        public static int AgregateMax(int[] array)
        {
            int max = array.Aggregate(0, (result, next) => result < next ? next : result);
            return max;
        }

        public static double AgregateAverage(int[] array)
        {
            double average = array
                .Select(integ => (double)integ)
                .Aggregate((result, current) => (result + current)) / array.Count();
            return average;
        }
    }
}
