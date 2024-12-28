using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_CharacterCount_in_String
    {

        // First method
        public void charactercount()
        {
            string name = "Saurabh";
            int count = 0;

            foreach (char c in name)
            {
                count++;
            }

            Console.WriteLine("The count of characters in \"{0}\" is: {1}", name, count);


        }
    }
}
