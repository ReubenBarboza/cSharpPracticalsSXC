using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///////////////////////////////////////////LINQ  to Objects  understanding join//////////////////////
namespace CSharpPracticals
{
    public class Customer
    {
        public int cid { get; set; }  //make public
        public string cname { get; set; }//make public      


    }
    public class Order
    {
        public int oid { get; set; }  //make public
        public int pid { get; set; }//make public
        public int cid { get; set; }//make public        


    }
    
    public class Product
    {
        public int pid { get; set; }  //make public
        public string pname { get; set; }//make public
        public int price { get; set; }//make public        


    }
    




    // public class Product from LinQObject.cs file taken



    class LinqToProg
    {


        static void Main()
        {
            List<Customer> cust = PopulateCustomerData();
            List<Product> prod = PopulateProductData();
            List<Order> ord = PopulateOrderData();
            var result = from o in ord
                         join
                             p in prod on o.pid equals p.pid
                         join
                             c in cust on o.cid equals c.cid
                         select new { c.cname, p.pname }; //for multiple rec use new 


            foreach (var y in result)
            {


                Console.WriteLine("cust {0} purchased {1}", y.cname, y.pname);
            }
            Console.ReadKey();
        }




        static List<Customer> PopulateCustomerData()
        {
            List<Customer> cust = new List<Customer>();


            cust.Add(new Customer { cid = 1, cname = "john" });
            cust.Add(new Customer { cid = 2, cname = "mahesh" });
            cust.Add(new Customer { cid = 3, cname = "arti" });
            cust.Add(new Customer { cid = 4, cname = "sameer" });
            return cust;
        }
        static List<Product> PopulateProductData()
        {
            List<Product> prod = new List<Product>();


            prod.Add(new Product { pid = 100, pname = "hp comp", price = 4000 });
            prod.Add(new Product { pid = 200, pname = "sofa", price = 9000 });
            prod.Add(new Product { pid = 300, pname = "table", price = 7000 });
            prod.Add(new Product { pid = 400, pname = "tv", price = 9000 });


            return prod;
        }
        static List<Order> PopulateOrderData()
        {
            List<Order> ord = new List<Order>();


            ord.Add(new Order { oid = 501, pid = 100, cid = 1 });
            ord.Add(new Order { oid = 502, pid = 200, cid = 2 });
            ord.Add(new Order { oid = 503, pid = 300, cid = 3 });
            ord.Add(new Order { oid = 504, pid = 400, cid = 4 });


            return ord;
        }


    }
}