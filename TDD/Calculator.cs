using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Calculator
    {
        public Calculator() 
        {
            add(3, 5);
        }
         public double add(double a, double b)
        {
            return a + b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        [Test]
        public double Divide(double a, double b)
        {
            return a / b;
        }

    }
}
