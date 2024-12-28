using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class ComparingTwoNumber
    {
        public void compareTwoNumbers()
        {
            int first, second;

            Console.WriteLine("Enter the first number : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(first > second ? "First number is greater than the second number" : "First number is smaller than the second number");

        }
    }
}
