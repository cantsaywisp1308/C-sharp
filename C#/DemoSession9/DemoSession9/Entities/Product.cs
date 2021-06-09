using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession9.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set;}

        public override string ToString()
        {
            return "ID: "+Id +"\nName: "+Name + "\nPrice: "+Price + "\nQuantity: "+ Quantity;
        }
    }
}
