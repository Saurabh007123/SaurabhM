using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class A
    {

        public static void LargestNumber()
        {
            int[] Numbers = { 10, 4, 33, 5, 66, 7 };
            int MaxNum = Numbers[0];
            for(int i=1; Numbers.Length > i;i++)
              if(Numbers[i] > MaxNum)
              {
                  MaxNum = Numbers[i];
              }
            Console.WriteLine(MaxNum);


        }

    }
}
