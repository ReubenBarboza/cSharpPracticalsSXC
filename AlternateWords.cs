using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpPracticals
{
    static class AlternateWords
    {
        static string Reverse(string str)
        {
            var reversedWords = string.Join(" ",
            str.Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            return reversedWords;
            
            //return str.Reverse().ToString();
        }

        static void UniqueString(string str)
        {
            string remove = str.Trim().Replace(".", "").Replace(":","").Replace("\t","");
            string duplicate = string.Join(" ", remove.Split(' ').Distinct());
            Console.WriteLine(duplicate);
        }
        static void WordExtractor(int index,string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] separator = { " ", "." };
            string[] words = new string[100];
            for (int i = 0; i < str.Length; i++)
            {
                words = str.Split(separator,1000,
                   StringSplitOptions.RemoveEmptyEntries);
                
            }
            for (int j = 0; j < words.Length; j++)
            {
                if (j == index)
                {
                    Console.WriteLine("Exact: "+words[j]);
                    Console.WriteLine("Previous: " + words[j-1]);
                    Console.WriteLine("After: " + words[j + 1]);
                }
            }

        }
        static StringBuilder Magic(string[] str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append(Reverse(str[i]) + "\n");
                }
                else
                {
                    sb.Append(str[i] + "\n");
                }
            }
            return sb;
        }
        static StringBuilder Ding(string[] str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 != 0)
                {
                    string[] word = str[i].Split(" ", 1000, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < word.Length; j++)
                    {

                        if (j % 2 != 0)
                        {
                            sb.Append(Reverse(word[j])+" ");
                        }
                        else
                        {
                            sb.Append(word[j]+ " ");
                        }
                    }

                }
                else
                {
                    sb.Append(str[i] + "\n");
                }
            }
            return sb;
        }
        
        static void Main()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Rohan\source\repos\CSharpPracticals\CSharpPracticals\test.txt");
            string text = System.IO.File.ReadAllText(@"C:\Users\Rohan\source\repos\CSharpPracticals\CSharpPracticals\test.txt");
            Console.WriteLine("-----Ding------");
            Console.WriteLine(Ding(lines));
            Console.WriteLine("-----Magic-----");
            Console.WriteLine(Magic(lines));
            Console.WriteLine("-----WordExtractor-----");
            Console.WriteLine("Enter index:");
            int i = Convert.ToInt32(Console.ReadLine());
            WordExtractor(i, text);
            Console.WriteLine("-----UniqueString-----");
            UniqueString(text);

            /*foreach(string line in lines)
             {
                 Console.WriteLine(line);
             }*/



        }
    }
}
    
