using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo1
    {
        public delegate void Say();
        public void Hello()
        {
            Debug.WriteLine("Hello");
        }

        public void Hi()
        {
            Debug.WriteLine("Hi");
        }

        public void Bye()
        {
            Debug.WriteLine("Bye");
        }

        public void Run()
        {
            Say say = new Say(Hello);
            say();

            say = new Say(Bye);
            say();

            say = Hi;
            say();
        }

    }
}
