using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpPracticals
{
    class RegexDemo
    {
        static void Main()
        {
            // This will return pattern 
            // will cd, cdcd, cdcdcd, ... 
            Regex regex = new Regex(@"(cd)+");

            Match match = regex.Match("mmcdde");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            Console.ReadKey();
        } 
        
    }
}
