using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPracticals
{
    
    class StringPractical
    {
        public static string spacecompressor(string x)
        {
            string output = "";
            String[] separator = { ",", ".", ":", " ","\t" };
            Int32 count = 1000;
            String[] strlist = x.Split(separator, count,
                   StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strlist)
            {
                output = output + " " + s;
            }
            return output.Trim();
        }
        static void Main()
        {
            string s1 = "This is java pracs";
            string s2 = " , right?";
                 //Q1 string methods
            //1 Concat
             Console.WriteLine("1) " + string.Concat(s1, s2));
            //2 Contains
            Console.WriteLine("2) " + s1.Contains("are"));
            //3 EndsWith
            Console.WriteLine("3) " + s1.EndsWith("s"));
            //4 Equals
            Console.WriteLine("4 )" + s1.Equals(s2));
            //5 IndexOf
            Console.WriteLine("5) " + s1.IndexOf("m"));
                //String Builder methods
            StringBuilder sb = new StringBuilder("Greetings from Reuben");
            //1 ToString
            Console.WriteLine("1) " + sb.ToString());
            //2 Append
            Console.WriteLine("2) " + sb.Append(" Hello"));
            //3 AppendLine
            Console.WriteLine("3) " + sb.AppendLine(" Relax"));
            //4 Insert
            Console.WriteLine("4) " + sb.Insert(9, " hi"));
            //5 Remove
            Console.WriteLine("5) " + sb.Remove(9, 3));

            //Q 2 file
            Console.WriteLine("----Reading all text----");
            string text = System.IO.File.ReadAllText(@"C:\Users\Rohan\source\repos\CSharpPracticals\CSharpPracticals\test.txt");
            Console.WriteLine(text);

            //Q3 line file
            Console.WriteLine("----Reading line text----");
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Rohan\source\repos\CSharpPracticals\CSharpPracticals\test.txt");
            string[] text2 = text.Split(" ", 1000, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Contents of line by line = ");
            foreach (string line in text2)  
            {
                Console.WriteLine(line);
            }

            //Q4 spacecompressor method
            Console.WriteLine("---spacecompressor method----");
            Console.WriteLine(spacecompressor(text));


        }
    }
}
