using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession6.Entities
{
    class Human : IHuman, IHuman2, IB  //1 class cóp thể kế thừa nhiều interface, và phải định nghĩa các hàm trong interface
    {
        public string Name { get; set; }

        void IHuman.A()
        {
            Console.WriteLine("A of IHuman");
        }

        void IHuman2.A()
        {
            Console.WriteLine("A of IHuman2");
        }

        public void Eat()
        {
            Console.WriteLine(Name + " Eat");
        }

        public string Run()
        {
            return Name + " Run";
        }

        public void Sleep()
        {
            Console.WriteLine(Name + " Sleep");
        }

        public void b1()
        {
            throw new NotImplementedException();
        }

        public void b2()
        {
            throw new NotImplementedException();
        }

        public void c1()
        {
            throw new NotImplementedException();
        }

        public void c2()
        {
            throw new NotImplementedException();
        }

        public void d1()
        {
            throw new NotImplementedException();
        }

        public void d2()
        {
            throw new NotImplementedException();
        }
    }
}
