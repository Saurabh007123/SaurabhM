using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class FromString
    {

        public static void RemoveDuplicates()
        {
            string str = "CsharpCorner";

            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);

            string testString = "abbbbccd";
            //var charGroups = (from c in testString
            //                  group c by c into g
            //                  select new
            //                  {
            //                      c = g.Key,
            //                      count = g.Count(),
            //                  }).OrderByDescending(c => c.count);
            //foreach (var group in charGroups)
            //{
            //    Console.WriteLine(group.c + ": " + group.count);
            //}

                       int length = testString.ToCharArray().GroupBy(x => x).OrderByDescending(x =>
            x.Count()).First().Count();

           
            Console.WriteLine(length);
        }
    }
    }

