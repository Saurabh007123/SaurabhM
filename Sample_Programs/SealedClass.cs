using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class ScientificCalculator 
    {
        public void SquareRoot(double x)
        {
            SealedClass sc = new SealedClass();
        }
    }
}
