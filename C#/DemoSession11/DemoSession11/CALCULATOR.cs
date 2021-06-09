using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSession11
{
    public class CALCULATOR
    {
        public delegate void calulate(int a, int b, string Operator);
        public event calulate Add;
        public event calulate Minus;
        public event calulate Multiple;
        public event calulate Divide;

        public void Run(int a,int b,string Operator)
        {
            if(Operator == "+")
            {
                if(Add != null)
                {
                    Add(a, b, Operator);
                }
            }
            if(Operator == "-")
            {
                if(Minus!= null)
                {
                    Minus(a, b, Operator);
                }
            }
            if (Operator == "*")
            {
                if (Multiple != null)
                {
                    Multiple(a, b, Operator);
                }
            }
            if (Operator == "/")
            {
                if (Divide != null)
                {
                    Divide(a, b, Operator);
                }
            }
        }
    }
}
