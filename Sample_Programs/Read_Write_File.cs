using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sample_Programs
{
    public class Read_Write_File
    {
        public static void FileWriting()
        {
            string path = "filename.txt";
            StringWriter sw = new StringWriter();
            StringReader sr = new StringReader(path);
            while (sr.ReadLine() != null)
            {
                string line = sr.ReadToEnd();
            }
           // File.WriteAllText("filename.txt", "My Name is Saurabh");
            string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
            Console.WriteLine(readText);


        }
    }
}
