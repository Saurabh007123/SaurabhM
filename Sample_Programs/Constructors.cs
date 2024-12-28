using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    public class ParentClass
    {
        public ParentClass(int a)
        {
            Console.WriteLine("Parent Class Constructor Called");
        }

        private ParentClass()
        {

        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }

        static ParentClass()
        {
            Console.WriteLine("Static Constructor is called");
        }

    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("DerivedClass Consturctor Overloading")
        {

        }
        /* Constructors are used to initialized the fields and private constructor neither allowed to inherit nor allowed to create
          the instance of the public class */
        /* Abstract class can have the constructor */
        /* static constructor must be parameterless and can not be inherited and no access modifier */
        /* Read only field can be modified only in static constructors
        /* public and private constructor can be defined for the same class but public constructor must have parameter */
       
    }
}
