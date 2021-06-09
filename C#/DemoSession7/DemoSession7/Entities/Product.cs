using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession7.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public string Category { get; set; }

        public void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Created: " + Created.ToShortDateString());
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Category " + Category);
        }
    }
}
