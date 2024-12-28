using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_FrequencyOfDigits
    {
        public static void FrequencyOfDigits()
        {
            //  method - 2

            int[] arr = new int[] { 10, 20, 20, 10, 10, 20, 5, 20 };
            int[] freq = new int[100]; // Assuming all digits are within the range 0-99

            foreach (int num in arr)
            {
                freq[num]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine("{0}: {1}", i, freq[i]);
                }
            }


        }
    }
}
