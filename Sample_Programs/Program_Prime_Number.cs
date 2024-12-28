using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_Prime_Number
    {

        public static void PrimeNumber()
        {
            Console.Write("Enter a number: ");
           int Num = int.Parse(Console.ReadLine());
            int count = 0;
            if (Num>0)
            {
                for(int i = 1; i <= Num; i++)
                {
                    if(Num%i==0)
                    {
                        count++;
                    }
                }
              
            }
            if (count == 2)
            {
                Console.WriteLine("Number is prime");

            }
            else
            {
                Console.WriteLine("Number is not prime");
            }

        }

    }
    }

