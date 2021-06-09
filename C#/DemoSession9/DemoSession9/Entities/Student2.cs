using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession9.Entities
{
    public partial class Student
    {
        public string Name { get; set; }
        public void Work1()
        {
            Console.WriteLine("Work 1");
        }
    }
}
