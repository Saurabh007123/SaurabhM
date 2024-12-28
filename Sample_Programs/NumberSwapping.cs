using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class c
    {

        public static void Swapping_FirstApproach()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            arr[0] = arr[0] + arr[6];  // 8
            arr[6] = arr[0] - arr[6];  // 8-7 = 1
            arr[0] = arr[0] - arr[6]; // 8-1 = 7
            Console.WriteLine(arr);
            foreach (int Num in arr)
            {
                Console.Write(Num + ",");

            }

            Console.WriteLine();
        }

        public static void Swapping_SecondApproach()
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            arr[0] = arr[0] + arr[6];  // 8
            arr[6] = arr[0] - arr[6];  // 8-7 = 1
            arr[0] = arr[0] - arr[6]; // 8-1 = 7

            string result = string.Join(",", arr);
            Console.Write(result);
        }
    }
}
