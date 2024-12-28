using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    public class Program_Starts_Triangle
    {
        public static void Traingle()
        {
            for (int i = 1; i <= 6; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Inverted Traingle 

            //for (int i = 6; i <= 6; --i)
            //{
             //   for (int j = 1; j <= i; ++j)
               // {
               //     Console.Write("*");
              //  }
              //  Console.WriteLine();
           // }

        }
    }

}