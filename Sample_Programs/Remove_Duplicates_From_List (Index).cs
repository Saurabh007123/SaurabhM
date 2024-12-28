using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Remove_Duplicates_From_List
    {
        public void List1()
        {

            

            // Removing the object from the list using indeces 

            List<string> distinct = new List<string>();
            
            List<string> result1 = new List<string>();
            List<string> NewResult = new List<string>();

            for (int i = 0; i < result1.Count; i++)
            {
                if (!result1.Contains(result1[i]))
                    NewResult.Add(result1[i]);
            }

            Console.WriteLine(NewResult);

            // Removing the object from the listing without indeces

            List<string> result21 = new List<string>();
            distinct = result21.Distinct().ToList();

            // var uniqueItems = allItems.DistinctBy(i => i.Id);




        }
    }
}
