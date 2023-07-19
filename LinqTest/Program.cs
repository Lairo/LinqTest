using System.Collections.Generic;

namespace LinqTest
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 99; i++)
                numbers.Add(i);
            IEnumerable<int> firstAndLastFive = numbers.Take(5)
        }
    }
}
