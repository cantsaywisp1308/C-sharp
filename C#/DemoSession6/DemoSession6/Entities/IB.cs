using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession6.Entities
{
    interface IB : IC,ID
    {
        void b1();
        void b2();
    }
}
