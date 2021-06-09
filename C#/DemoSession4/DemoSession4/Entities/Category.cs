using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession4.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return "ID: " + Id + "\nName: " + Name;
        }
    }
}
