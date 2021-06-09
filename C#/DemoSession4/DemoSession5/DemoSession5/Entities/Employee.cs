using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Employee : Human
    {
        public string Id { get; set; }
        public int Salary { get; set; }

        public Employee() { }
        public Employee(string name, string gender, string id, int salary): base(name,gender)
        {
            Id = id;
            Salary = salary;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("id: " + Id);
            Console.WriteLine("salary: " + Salary);
        }

        public override void Input()
        {
            Console.WriteLine("Input Employee: ");

        }
    }
}
