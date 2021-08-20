using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpPracticals
{
    class ZipMore
    {
        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>()
            {
                1,2,3,4,5
            };

            IList<string> secondList = new List<string>()
            {
                "One","Two","Three","Four","Five"
            };
            var result1 = firstList.Zip(secondList, (x, y) => x + ":" + y+":"+x*x);
            var result2 = firstList.Where(x => x % 2 == 1).Zip(secondList, (x, y) => x + ":" + y);
            Console.WriteLine("---Q1---");
            result1.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---Q2---");
            result2.ToList().ForEach(x => Console.WriteLine(x));

            Console.ReadKey();
        }
    }
}
