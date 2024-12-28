using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    class B
    {
        public static void ReverseString()
        {

            string original = "Hello World!";
            StringBuilder reversed = new StringBuilder(original.Length);
            for (int i = original.Length - 1; i >= 0; i--)
            {
                reversed.Append(original[i]);
            }
            Console.WriteLine(reversed);
        }
        // reverse the string with string builder
        public static void Reverse_the_characters_maintaining_words_in_its_own_place()
        {
            string txt = "How are you?";
            string[] txtSplit = txt.Split(' ');
            string result = string.Empty;
            int len_txt = txtSplit.Length;
            StringBuilder sb = new StringBuilder();
            foreach (string s in txtSplit)
            {
                sb.Clear();
                int l = s.Length;
                for(int i= l-1; i>=0; i--)
                result += s[i] + " ";
                //sb.Append(s[i]);
               //sb.Append(' ');
                
                Console.WriteLine(sb);

            }
        }

        //Displaying the reverse word  
        //string str1 = string.Join(" ", original.Split(" ").Select(s => new string(s.Reverse().ToArray())));

        //string Str2 = string.Join(" ", original.Split(" ").Select(s => new string(s.Reverse().ToArray())));

        // can we reverse a list also

    }

       
           
        }
    

