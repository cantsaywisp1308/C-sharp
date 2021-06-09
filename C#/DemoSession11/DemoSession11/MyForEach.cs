using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession11
{
    public class MyForEach
    {
        public delegate void ReadElement(int value,int index);
        public event ReadElement PositiveNumberEvent;
        public event ReadElement NegativeNumberEvent;
        public void Run(List<int> list)
        {
            for(var i = 0; i < list.Count; i++)
            {
                if(list[i] >=0)
                {
                    if(PositiveNumberEvent != null)
                    {
                        PositiveNumberEvent(list[i], i);
                    }
                }
                if (list[i] < 0)
                {
                    if(NegativeNumberEvent != null)
                    {
                        NegativeNumberEvent(list[i], i);
                    }
                }
            }
        }
    }
}
