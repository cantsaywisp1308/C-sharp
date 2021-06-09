using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession5.Entities
{
    public class Chicken : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Chicken sounds: " + Name + "Cock a doodle doo");
        }
    }
}
