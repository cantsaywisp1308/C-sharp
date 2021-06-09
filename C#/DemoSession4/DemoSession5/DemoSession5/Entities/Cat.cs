using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("A cat sounds: " + Name + "Meow meow");
        }
    }
}
