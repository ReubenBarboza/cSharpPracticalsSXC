using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPracticals
{
    class Student
    {
        // Creating setter and getter for each property  
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class P2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.ID = "100";
            s1.Name = "Reuben";
            s1.Email = "rb@gmail.com";
            Student s2 = new Student();
            s2.ID = "101";
            s2.Name = "Vishal";
            s2.Email = "vc@gmail.com";
            Student s3 = new Student();
            s3.ID = "102";
            s3.Name = "Kenneth";
            s3.Email = "km@gmail.com";
            Student s4 = new Student();
            s4.ID = "103";
            s4.Name = "Abey";
            s4.Email = "ag@gmail.com";
            Student s5 = new Student();
            s5.ID = "104";
            s5.Name = "Tiju";
            s5.Email = "tt@gmail.com";
            Console.WriteLine("Enter id of Student:");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a==Convert.ToInt32(s1.ID))
            {
                Console.WriteLine("Id is {0}, Name is {1}, Email is {2}", s1.ID, s1.Name, s1.Email);
            }
            else if (a == Convert.ToInt32(s2.ID))
            {
                Console.WriteLine("Id is {0}, Name is {1}, Email is {2}", s2.ID, s2.Name, s2.Email);
            }
            else if (a == Convert.ToInt32(s3.ID))
            {
                Console.WriteLine("Id is {0}, Name is {1}, Email is {2}", s3.ID, s3.Name, s3.Email);
            }
            else if (a == Convert.ToInt32(s4.ID))
            {
                Console.WriteLine("Id is {0}, Name is {1}, Email is {2}", s4.ID, s4.Name, s4.Email);
            }
            else if (a == Convert.ToInt32(s5.ID))
            {
                Console.WriteLine("Id is {0}, Name is {1}, Email is {2}", s5.ID, s5.Name, s5.Email);
            }
        }
    }
}
