using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class E
    {
        public static bool Compare_Lists_and_Remove_Duplicates()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 1, 2, 3 };

            // Example with strings
            List<string> strList1 = new List<string>() { "apple", "banana", "cherry" };
            List<string> strList2 = new List<string>() { "apple", "banana", "cherry" };


            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }

            return true;

           
            
            var newList = list1.Intersect(list2).ToList();

            list1.Clear();
            list1.AddRange(newList);

            

        }
    }
}
