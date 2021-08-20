using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;
using System.Linq.Expressions;
//using System.Windows.Forms;
namespace CSharpPracticals
{
    class LinqXML
    {
        static void Main()
        {
            XDocument pd = XDocument.Load("C:\\Users\\Rohan\\source\\repos\\CSharpPracticals\\CSharpPracticals\\MyXml.xml");
            var products = pd.Elements();
            Console.WriteLine("====Q1 display products using lamda expression====");
            var result = products.Elements("Product")
                .Where(x => (int)x.Element("price") > 40000)
                .Select(x =>
                new
                {
                    Name = x.Element("pname").Value,
                    price = x.Element("price").Value,
                    dom=x.Element("dom").Value
                }
                    );
            Console.WriteLine("Display all products");
            foreach(var p in result)
            {
                Console.Write(p);
            }
            //Q2
            Console.WriteLine("======Q2 LINQ======");
            var pr = from x in products.Elements("Product")
                     where DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yy", null) >
                           DateTime.ParseExact("10-07-14", "dd-mm-yy", null)
                     let nm = (string)x.Element("pname")
                     select nm;
            Console.WriteLine("*******");
            foreach(var p1 in pr)
            {
                Console.WriteLine(p1);
            }
            Console.WriteLine("*******");
            //Q3
            Console.WriteLine("======Q3 LINQ with multiple cond======");
            var p2 = from x in products.Elements("Product")
                    where ((int)x.Element("price") > 40000 &&
                    (DateTime.ParseExact((string)x.Element("dom"), "dd-mm-yy", null)) >
                    DateTime.ParseExact("11-07-14", "dd-mm-yy", null))
                    select new { pname = (string)x.Element("pname"), prprice = (int)x.Element("price") };

            foreach(var p1 in p2)
            {
                Console.WriteLine(p1);
            }
        }
        
    }
}
