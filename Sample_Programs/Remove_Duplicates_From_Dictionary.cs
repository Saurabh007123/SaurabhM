using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class From_Dictionary
    {

        public static void RemoveDuplicates()
        {

            // Method = 1

            IDictionary<string, string> myDict = new Dictionary<string, string>();

            myDict.Add("1", "blue");
            myDict.Add("2", "blue");
            myDict.Add("3", "red");
            myDict.Add("4", "green");

            HashSet<string> knownValues = new HashSet<string>();
            Dictionary<string, string> uniqueValues = new Dictionary<string, string>();

            foreach (var pair in myDict)
            {
                if (knownValues.Add(pair.Value))
                {
                    uniqueValues.Add(pair.Key, pair.Value);
                }
            }
            Console.WriteLine(uniqueValues);

            // Method = 2

            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("1", "blue");
            test.Add("2", "blue");
            test.Add("3", "green");
            test.Add("4", "red");
            Dictionary<string, string> test2 = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in test)
            {
                if (!test2.ContainsValue(entry.Value))
                    test2.Add(entry.Key, entry.Value);
            }

            Console.WriteLine(test2);


        }
    }
}
