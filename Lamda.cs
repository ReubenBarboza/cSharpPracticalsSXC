using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CSharpPracticals
{
    class Animal
    {
        public string Name { get; set; } 
        public int Age { get; set; }
    }
    class Lamda
    {
        static void Main()
        {
            List<Animal> dogs = new List<Animal>()
            {
                new Animal {Name = "Rex",Age=4},
                new Animal {Name = "Sean",Age=0},
                new Animal {Name = "Stacy",Age=3},

            };
            var names = dogs.Select(x=> new{ name = x.Name,age = x.Age});
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.Read();
        }
    }
}
