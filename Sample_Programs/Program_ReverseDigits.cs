using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_ReverseDigits
    {
        public static void ReverSeNumber()
        {
            Console.WriteLine("Enter a No. to reverse");
            int Number = int.Parse(Console.ReadLine());
            int Reverse = 0;
            while (Number > 0)
            {


                int remainder = Number % 10;
                Number = Number / 10;
                
                Reverse = (Reverse * 10) + remainder;
            }
            Console.WriteLine("Reverse No. is {0}", Reverse);
            Console.ReadLine();
            

        }
    }
}
