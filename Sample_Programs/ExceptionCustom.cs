using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    [Serializable]
    public class StudentNotFoundException : Exception 
    {

        public string StudentName { get; }
        public StudentNotFoundException() 
        { 
        
        }

        public StudentNotFoundException(string message) : base(message)
        {
        
        }

        public StudentNotFoundException(string message, Exception inner) : base(message, inner) 
        { 
           
        
        }
        public StudentNotFoundException(string message, string studentName): this(message)
        {
            StudentName = studentName;

        }

    }

    
}
