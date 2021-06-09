using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession16.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Min:Attribute
    {
        public int Value { get; set; }
        public Min(int value)
        {
            Value = value;
        }
    }
}
