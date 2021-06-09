using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession7.Entities
{
    public class Invoice
    {
        /*Xay dung class Invoice co cac thuoc tinh sau:
            1. id kieu chuoi
            2. total kieu so thuc
            3. payment kieu chuoi
            4. status kieu chuoi
            5. customer kieu Customer
            6. created kieu datetime*/
        public string Id { get; set; }
        public double Total { get; set; }
        public string Payment { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
        public DateTime Created { get; set; }

        public void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Total: " + Total);
            Console.WriteLine("Payment: " + Payment);
            Console.WriteLine("Created: " + Created);
            Customer.Print();
        }
    }
}
