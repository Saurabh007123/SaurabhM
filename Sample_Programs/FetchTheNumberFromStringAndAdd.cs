using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class F
    {
        public static void FetchTheNumberFromStringAndAdd()
        {

            string s = "emrm3m4m5j67";
            int sum = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    sum += int.Parse(c.ToString());
                }
            }

            Console.WriteLine($"Sum of numbers in string: {sum}");
        }

    }
    
}
