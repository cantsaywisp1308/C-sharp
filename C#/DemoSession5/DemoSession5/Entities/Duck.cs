using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Duck : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Duck sounds" + Name + "Quack quack");
        }
    }
}
