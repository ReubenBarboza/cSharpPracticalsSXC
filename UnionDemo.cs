using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSharpPracticals
{
    class UnionDemo
    {
        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>()
            {
                1,2,3,4
            };
            IList<int> secondList = new List<int>()
            {
               7,9,3,4,5,6,7
            };

            var result = firstList.Union(secondList);
            result.ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}