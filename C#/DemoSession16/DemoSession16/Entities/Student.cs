using DemoSession16.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession16.Entities
{

    [Author(Value ="Kevin")]
    [MyClass(Description = "for testing",Date ="2021-05-21")]
    public class Student
    {
        [Author(Value ="Mary")]
        public string Id { get; set; }
        public string Name { get; set; }
        [Min(0)]
        public double Score { get; set; }
        
        [Author(Value ="Teo 1")]
        [Author(Value = "Teo 2")]
        [Author(Value = "Teo 3")]

        public void Print()
        {

        }
    }
}
