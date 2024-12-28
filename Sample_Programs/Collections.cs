using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Programs
{
    internal class Collections
    {
        
        public static void List()
        {
            // Generic collection
            // duplicates can be added in List
            // System.Collections.Generic
            List<int> intList = new List<int>();  // Create a list of integers
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            List<string> stringList = new List<string>();  // Create a list of strings
            stringList.Add("Apple");
            stringList.Add("Banana");
            stringList.Add("Cherry");


        }

        public static void Dictionary()
        {
            // Dic is generic
            // duplicate keys are not allowed
            // key can not be null
            Dictionary<int, string> Dic = new Dictionary<int, string>();
            Dic.Add(1, "MCA");
            Dic.Add(4, "MBA");
            Dic.Add(2, "BCA");
            foreach (KeyValuePair<int, string> ele1 in Dic)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            var posi = from a in Dic
                       where a.Value == "MBA"
                       select a.Key;

            var keys = Dic.Where(d => d.Value == "ABC").Select(d => d.Key);

        }

        public static void Queue()
        {
            // First in first out
            // duplicates are allowed
            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("MCA");
            myQueue.Enqueue("MBA");
            myQueue.Enqueue("BCA");

            myQueue.Dequeue();  //MCA will be removed as first MCA was inserted
            myQueue.Dequeue();  //MBA will be removed as first MBA was inserted

            myQueue.Clear();

        }

        public static void Stack()
        {
            // Last in first out
            Stack myQueue = new Stack();
            myQueue.Push("MCA");
            myQueue.Push("MBA");
            myQueue.Push("BCA");

            myQueue.Pop();  //BCA will be removed as first MCA was inserted
            myQueue.Pop();  //MBA will be removed as first MBA was inserted

            myQueue.Clear();
            

        }

        public static void ArrayList()
        {
            // array list is non generic
            // here duplicates can be added
            ArrayList Alist = new ArrayList();
            Alist.Add("MCA");
            Alist.Remove("");
            Alist.RemoveAt(1);

        }

        public static void HashTable()
        {
            // is non generic
            // duplicate keys are not allowed
            // key can not be null
            Hashtable HTable = new Hashtable();
            HTable.Add(1,"MCA");
            HTable.Add("3","MBA");
            HTable.Add(2," ");
            foreach (DictionaryEntry ele1 in HTable)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }
            

        }

        

        public static void HashSet()
        {
            // HashSet is generic
            // duplicate in Hashset is not allowed
            // nulls are not allowed in hashset
            HashSet<string> HSet= new HashSet<string>();
            HSet.Add("MCA");
            HSet.Add("MCA");

           
        }

        public static void Connectionqa()
        {
            SqlConnection conn = new SqlConnection("ConnectionString");
            conn.ConnectionString =
              "Data Source=ServerName;" +
              "Initial Catalog=DataBaseName;" +
              "Integrated Security=SSPI;";
            conn.Open();

        }
    }
}
