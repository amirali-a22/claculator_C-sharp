using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal interface ICalculate
    {
        int Plus(int x, int y);
        int Divide(int x, int y);
        int Multiple(int x, int y);
        int Minus(int x, int y);
    }
}
