using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Array_Remove_Duplicates_From_Array
    {

        public static void Array_Remove_Duplicates_From_()
        {
            int[] iArray = { 1, 2, 3, 2, 3, 4, 3 };
            iArray.GroupBy(x => x).Select(x => x.First());

            // find the distinct value from the array list
            int i = 0, j = 0;
            int[] arr1 = new int[] { 7, 7, 8, 8, 9, 1, 1, 4, 2, 2 };
            int length = arr1.Length;
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr1.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr1[j] == arr1[i])
                        break;
                }
                if (arr1.Length == j)
                {
                    Console.Write(arr1[i] + " ");
                }
            }


            int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] dist = nums.Distinct().ToArray();

            string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };
            string[] birds = { "Sparrow", "Peacock", "Dove", "Crow" };

            var all = animals.Union(birds).ToArray();


            // remove duplicates from List

            List<int> listWithDuplicates = new List<int> { 1, 2, 1, 2, 3, 4, 5 };

            HashSet<int> hashWithoutDuplicates = new HashSet<int>(listWithDuplicates);
            List<int> listWithoutDuplicates = hashWithoutDuplicates.ToList();
            foreach (var item in listWithoutDuplicates)
            {
                Console.WriteLine(item);
            }
        }
    }
}

