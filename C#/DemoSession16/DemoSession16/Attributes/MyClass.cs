using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession16.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MyClass : Attribute
    {
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
