using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo4
    {
        public delegate double Calculate(double a, double b);
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Multiple(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public void Run()
        {
            
            Calculate calculate = Add;
            Debug.WriteLine(calculate(19, 20));
            calculate = Minus;
            Debug.WriteLine(calculate(19, 20));
            calculate = Multiple;
            Debug.WriteLine(calculate(19, 20));
            calculate = Divide;
            Debug.WriteLine(calculate(19, 20));
        }
    }
}
