using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace CSharpPracticals
{
    class ExceptDemo
    {
        static void Main(string[] args)
        {
            IList<int> firstList = new List<int>()
            {
                1,2,3,4
            };
            IList<int> secondList = new List<int>()
            {
               1,2,3
            };

            var result = firstList.Except(secondList).ToList();
            result.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
