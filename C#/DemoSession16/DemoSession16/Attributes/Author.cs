using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession16.Attributes
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property|AttributeTargets.Method,AllowMultiple =true)]
    public class Author :Attribute
    {
        public string Value { get; set; }
    }
}
