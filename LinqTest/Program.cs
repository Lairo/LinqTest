using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqTest
{

    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 99; i++)
                numbers.Add(i);


            //IEnumerable<int> firstFive = numbers.Take(5);
            //IEnumerable<int> lastFive = numbers.TakeLast(5);

            IEnumerable<int> lastFive = numbers.Skip(numbers.Count() - 5);
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(lastFive);


            foreach (int i in firstAndLastFive)
            {
                Console.Write($"{i} ");
            }
        }
    }
}