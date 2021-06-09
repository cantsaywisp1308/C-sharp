using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Animal
    {
        public string Name { get; set; }
        public virtual void Sound() { }
    }
}
