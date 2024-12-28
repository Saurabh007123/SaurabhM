using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    public class TestStatic
    {
        public static int TestValue = 0;

        public TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }
        static TestStatic()
        {
            if (TestValue == 0)
            {
                TestValue = 10;
            }

        }

        public static void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
                Console.WriteLine("TestValue : " + TestValue);
            }
            else
            {
                Console.WriteLine("TestValue : " + TestValue);
            }
           // Console.WriteLine("TestValue : " + TestValue);

        }
    }


}


