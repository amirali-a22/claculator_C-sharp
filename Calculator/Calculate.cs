using Calculate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculate : ICalculate
    {
        public int Divide(int x, int y)
        {
            return x / y;
        }

        public int Minus(int x, int y)
        {
            return (x - y);
        }

        public int Multiple(int x, int y)
        {
            return x * y;
        }

        public int Plus(int x, int y)
        {
            return x + y;
        }
    }
}
