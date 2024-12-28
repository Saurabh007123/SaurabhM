using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
     class ReadOnlyVsConstants
    {
        public const int cmTom = 100; // compile time constant
        public static readonly double PI;  // Runtime constant
        static ReadOnlyVsConstants()
        {
            PI = (double)Math.PI;
        }

    }

    class RemoveDuplicates
    {
       
        public static void Removeduplicate()
        {
            string Name = "Saurabh";
            char[] Naam = Name.ToCharArray();
            StringBuilder SR = new StringBuilder();
            foreach(char c in Naam)
            {
                if(SR.ToString().IndexOf(c) == -1)
                {
                    SR.Append(c);
                }
            }
        }

    }

    class RemoveDuplicatesFromArray
    {

        public static void RemoveDuplicates()
        {
            IList<int> unique = new List<int>();
            int[] Naam = { 1, 1, 2, 2, 3, 4, 5, 6, 6 };
            int[] newArray;
            foreach(int n in Naam)
            {
                if(!unique.Contains(n))
                {
                    unique.Add(n);
                }
                
            }

            newArray = new int[unique.Count];
            unique.CopyTo(newArray,0);


        }

    }
}
