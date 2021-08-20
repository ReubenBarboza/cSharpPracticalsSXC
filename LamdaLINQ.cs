using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CSharpPracticals
{
    class LamdaLINQ
    {
           static void Main()
        {
            XDocument pd = XDocument.Load("C:\\Users\\Rohan\\source\\repos\\CSharpPracticals\\CSharpPracticals\\MyXml2.xml");
            var Products = pd.Elements();
            Console.WriteLine("---Q1 Display product names with price which is less than Rs25000---");
            var result1 = Products.Elements("Product")
               .Where(x => (int)x.Element("price") < 25000)
               .Select(x => (string)x.Element("pname"));

            foreach(var r1 in result1)
            {
                Console.WriteLine(r1);
            }
            Console.WriteLine("---Q2 Display product with name price and dom which were manufactured after 10-07-2016---");
            var result2 = from x in Products.Elements("Product")
                          where DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yy", null) >
                                DateTime.ParseExact("10-07-16", "dd-mm-yy", null)
                          select new { Name = (string)x.Element("pname"), Price = (int)x.Element("price"), date = (string)x.Element("dom") };
            foreach (var r2 in result2)
            {
                Console.WriteLine(r2);
            }
            Console.WriteLine("---Q3 Display the name and cost of product which has maximum price.---");
            var result3 = from x in Products.Elements("Product")
                          where (int)x.Element("price") == pd.Descendants("price").Max(a => (int)a)
                          select new { Name = (string)x.Element("pname"), Price = (int)x.Element("price") };
            foreach (var r3 in result3)
            {
                Console.WriteLine(r3);
            }
            Console.WriteLine("---Q4 Write query with respect to multiple condition based on your xml file.---");
            var result4 = from x in Products.Elements("Product")
                          where (DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yy", null) <
                                 DateTime.ParseExact("12-02-16", "dd-mm-yy", null)) &&
                                 ((int)x.Element("price") > 90000)
                          select new { Name = (string)x.Element("pname"), Price = (int)x.Element("price"), Date = (string)x.Element("dom") };
            foreach (var r4 in result4)
            {
                Console.WriteLine(r4);
            }
        }
    }
}
