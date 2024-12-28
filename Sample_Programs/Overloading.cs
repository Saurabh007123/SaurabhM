using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    public class Overloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public string Add(string a, string b, string c)
        {
            return a + b;
        }
        public void Add(string a, string b)
        {
            
        }
    }
}
