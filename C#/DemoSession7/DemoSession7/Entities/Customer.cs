using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession7.Entities
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }

        public Customer() { }

        public void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Gender: " + Gender);
            Console.WriteLine("Birthday: " + Birthday);
        }
    }
}
