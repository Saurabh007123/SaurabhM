using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Program_SecondLargestNumber
    {

        public void SecondLargestNumberInArray()
        {

            int[] array = { 2, 11, 15, 1, 7, 99, 6, 85, 4 };
            Array.Sort(array); //sorting array  
            Array.Reverse(array); // Reverse Sorting array value  
            Console.WriteLine("Second Highest Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " "); // Array values   
            }

            // Method 2 

            int[] myArray = new int[] { 0, 11, 2, 15, 16, 8, 16, 8, 15 };
            int Smallest = myArray.Min();
            int Largest = myArray.Max();
            foreach (int i in myArray)
            {
                if (i > Smallest && i < Largest)
                {
                    Smallest = i;
                }
            }
            System.Console.WriteLine(Smallest);
            Console.ReadLine();


        }
    }
}
