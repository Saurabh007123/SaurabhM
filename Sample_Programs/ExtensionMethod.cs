using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Sample_Programs
{
    public static class IntExtensions
    {
        
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
        public static void Hello()
        {
            
                int sum = 0;
                // return i > value;
                string input = "India10world20test30";
                StringBuilder sb = new StringBuilder();
            for (int i=0; input.Length >= i;i++)
            {
                char[] c = input.ToCharArray();
                if(char.IsLetter(input[i]))
                {
                    sb.Append(c[i]);
                }
                else
                {
                    sum += c[i];
                }
                
                
            }

        }
    }
}
