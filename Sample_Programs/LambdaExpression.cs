using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class LambdaExpression1
    {

        public static void mymain()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            // Find the even Number
            List<int> evenNumbers = list.FindAll(x => (x%2) == 0);

            // getting the occurance of a single number at a time
            int occurrences = list.Count(x => x == 4);

            // getting four largest number

            var result = list.OrderByDescending(n => n).Take(4);
            Console.Write("{0} ", evenNumbers);

            // using lambda expression largest or min number from array can not be found except programming

        }
    }

    internal class LambdaExpression2
    {

        class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void mymain()
        {
            List<Dog> dogs = new List<Dog>() {
            new Dog { Name = "Rex", Age = 4 },
            new Dog { Name = "Sean", Age = 0 },
            new Dog { Name = "Stacy", Age = 3 }
         };
            
            var DogName = dogs.Select(x => x.Name);
            foreach(var Name in DogName)
            {
                Console.WriteLine(Name);
            }

            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name });
            
        }
    }
}
