using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_SumOfDigits
    {
        public static void SumOfDigits()
        {
            int n, sum = 0, r, d;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                n = n / 10;
                sum = r + n;
                Console.Write("Sum is= " + sum);
            }


        }
    }
}
