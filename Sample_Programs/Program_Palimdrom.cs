using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_Palimdrom
    {

        public static void PalindromeString()
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            Console.ReadKey();


        }

        public static void PalindromeStringNew()
        {
            string CatchString; 
            string revs = "";
            Console.WriteLine(" Enter string");
            CatchString = Console.ReadLine();
            StringBuilder SB = new StringBuilder();
            char[] S = CatchString.ToCharArray();

            for(int i=CatchString.Length-1; i>=0;i--)
            {
                SB.Append(CatchString[i]);
            }
            if (SB.Equals(CatchString)) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", CatchString, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", CatchString, revs);
            }
            Console.ReadKey();


        }
    }
}
