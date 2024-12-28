using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class BiggestNumberInArray_dup
    {

        public static void BigNumber()
        {
            // First method
            int[] list = { 10, 20, 22, 14, 15, 16, 8, 18 };
            int biggest = list[0];//list refer to your list's name
            for (int i = 1; i < list.Count(); ++i)
            {
                if (list[i] > biggest)
                {
                    biggest = list[i];
                }
                Console.WriteLine(biggest);
            }
            // Second method
            int g = list.Max(x => x);

            // Third method
            int[] arrays = { 10, 20, 12, 14, 15, 16, 17, 18 };
            Array.Sort(arrays);
            Array.Reverse(arrays);
            int largest = int.MinValue;

        }
    }
}
