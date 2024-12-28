using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    public class Employee
    {
        public virtual void printfulname()
        {
            Console.WriteLine("BaseEmployee");
        }
    }

    public class partimeEmployee : Employee
    {
        public override void printfulname()
        {
            Console.WriteLine("ParttimeEmployee");
        }
    }

    public class contractEmployee : Employee
    {
        public override void printfulname()
        {
            Console.WriteLine("contractEmployee");
        }
    }
}
