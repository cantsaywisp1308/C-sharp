using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Human
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public Human() { }
        public Human(string name, string gender)
        {
            Name = name;
            Gender = gender;
        }

        public void Print()
        {
            Console.WriteLine("name: " + Name);
            Console.WriteLine("gender: " + Gender);
        }

        public virtual void Input()
        {
            Console.WriteLine("Input Human: ");

        }
    }
}
