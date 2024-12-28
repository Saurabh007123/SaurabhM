using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Class2
    {

        public static void DictionaryLinq()
        {

            Dictionary<string, string> mydictionary = new Dictionary<string, string>();

            mydictionary.Add("Key 1", "Value 1");
            mydictionary.Add("Key 2", "Value 2");
            mydictionary.Add("Key 3", "3");

            var myKey = mydictionary.ContainsValue("Value");
            var key = mydictionary.Where(pair => pair.Value.Contains("Value"))
                     .Select(pair => pair.Key);


            foreach (KeyValuePair<string, string> kvp in mydictionary)
            {
                if (kvp.Value.Contains("value"))
                {
                    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

                }

            }

        }

        public static void ArrayLinq()
        {
           // String[] arr = new[] { "Dan", "Yossi", "Ben" };
           //string[] a = arr.Where(x => x.Contains("e")).ToArray();

            //Method - 2
            //from item in arr where item.Length == 3

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int oddNumbers = numbers.Count(n => n % 2 == 1);


            int[] numbers1 = { 2, 3, 4, 5 };
            var squaredNumbers = numbers1.Select(x => x * x);
            bool[] EvenNumber = numbers1.Select(x => x % 2 != 0).ToArray();

           int[] EvenNumber1 = numbers1.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(squaredNumbers);
            // Customers.Where(c => c.City == "London");
            // 
            List<person> persons = new List<person> {
            new person {name = "Sourav"},
            new person {name = "Sudip"},
            new person {name = "Ram"}
        };

           List<bool> personList = persons.Select(x => x.name.Contains("S")).ToList();
           List<person> personList_ = persons.Where(x => x.name.StartsWith("S")).ToList();
        }

        public static void ListLinq()
        {
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "Hard Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Monitor", type = "DISPLAY" });
            productList.Add(new ProductStore { category = 1, productName = "SSD Disk", type = "MEMORY" });
            productList.Add(new ProductStore { category = 1, productName = "RAM", type = "MEMORY" });
            productList.Add(new ProductStore { category = 2, productName = "Processor", type = "CPU" });
            productList.Add(new ProductStore { category = 1, productName = "Bluetooth", type = "Accessories" });
            productList.Add(new ProductStore { category = 2, productName = "Keyboard & Mouse", type = "Accessories" });

            //var result = from product in productList
            //             group product by product.category;

            var result = productList.GroupBy(p => p.category);

        }
    }

    class person
    {
        public string name { get; set; }
    }

    class ProductStore
    {
        public int category { get; set; }
        public string productName { get; set; }

        public string type { get; set; }
    }
}
