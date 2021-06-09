using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Student : Human
    {
        public string Id { get; set; }
        public double Score { get; set; }

        public Student() { }
        public Student(string name, string gender, string id, double score) : base(name, gender)
        {
            Id = id;
            Score = score;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("id: " + Id);
            Console.WriteLine("score: " + Score);
        }

        public new void Input()
        {
            Console.WriteLine("Input Student: ");

        }
    }
}
