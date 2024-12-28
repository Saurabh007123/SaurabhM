using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class D
    {

        public static void ComaparisionString1()
        {

            Console.WriteLine("Enter the First String :");
            Console.WriteLine("Enter the Second String :");

            string str_1 = Console.ReadLine();
            string str_2 = Console.ReadLine();
            int result = string.Compare(str_1, str_2);
            if (result == 0)
            {   
                Console.WriteLine("Both strings are equal");
            }
            else if (result < 0)
            {
                Console.WriteLine("First string is greater than the second string");
            }

            

        }
    }
}
