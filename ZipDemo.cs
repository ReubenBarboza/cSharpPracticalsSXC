using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPracticals
{
    class ZipDemo
    {
        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>()
            {
                1,2,3,4
            };

            IList<string> secondList = new List<string>()
            {
                "One","Two","Three","Four"
            };
            var result = firstList.Zip(secondList, (x, y) => x + ":" + y);

            result.ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
