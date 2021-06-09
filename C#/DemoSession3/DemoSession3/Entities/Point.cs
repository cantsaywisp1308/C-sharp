using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession3.Entities
{
    class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public void Input()
        {
            do {
                Console.Write("Y: ");
                X = int.Parse(Console.ReadLine());
            } while (X < -2000 || X > 2000);
            
            do {
                Console.Write("Y: ");
                Y = int.Parse(Console.ReadLine());
            } while (Y < -2000 || Y > 2000)
        }
    }
}
