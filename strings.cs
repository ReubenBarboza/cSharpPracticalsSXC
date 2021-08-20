using System;
using System.Text;

namespace CSharpPracticals
{
    class strings
    {
        static void Main(string[] args)
        {
            
            string s1 = "There are many string methods";
            string s2 = "   But practice makes you perfect";
            string[] s3 = { "Join", "of", "strings" };
            //string methods
            //1 Concat
             Console.WriteLine("1) "+string.Concat(s1, s2));
            //2 Contains
            Console.WriteLine("2) " + s1.Contains("are"));
            //3 EndsWith
            Console.WriteLine("3) "+s1.EndsWith("s"));
            //4 Equals
            Console.WriteLine("4 )"+s1.Equals(s2));
            //5 IndexOf
            Console.WriteLine("5) " + s1.IndexOf("m"));
            //6 Join
            Console.WriteLine("6) " + string.Join("-",s3));
            //7 LastIndexOf
            Console.WriteLine("7) " + s2.LastIndexOf("t"));
            //8 Replace
            Console.WriteLine("8) " + s1.Replace("many","lots of"));
            //9 StartsWIth
            Console.WriteLine("9) " + s1.StartsWith("t"));
            //10 Substring
            Console.WriteLine("10) " + s2.Substring(23));
            //11 ToLower
            Console.WriteLine("11) " + s1.ToLower());
            //12 ToUpper
            Console.WriteLine("12) " + s2.ToUpper());
            //13 Trim
            Console.WriteLine("13) " + s2.Trim());
            //14 IsNullOrEmpty
            Console.WriteLine("14) " + string.IsNullOrEmpty(s1));
            //15 Insert
            Console.WriteLine("15) " + s2.Insert(5,"-"));

            //string builder 
            StringBuilder sb = new StringBuilder("Greetings from Reuben");
            //1 ToString
            Console.WriteLine("1) " + sb.ToString());
            //2 Append
            Console.WriteLine("2) " + sb.Append(" Hello"));
            //3 AppendLine
            Console.WriteLine("3) " + sb.AppendLine(" Relax"));
            //4 Insert
            Console.WriteLine("4) " + sb.Insert(9," hi"));
            //5 Remove
            Console.WriteLine("5) " + sb.Remove(9,3));
            //6 Replace
            Console.WriteLine("6) " + sb.Replace("Relax","Chillax"));
            //7 AppendFormat
            Console.WriteLine("7) " + sb.AppendFormat("{0:C} ",25));

        }
    }
}
